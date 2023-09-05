using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EwidencjaZlecen.App.Abstract;
using EwidencjaZlecen.Domain.Common;
using EwidencjaZlecen.Domain.Entity;

namespace EwidencjaZlecen.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public BaseService ()
        {
            Items = new List<T> ();
        }
        public List<T> GetAllItems()
        {
            return Items;
        }
        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }
        public void RemoveItem(T item)
        {
            Items.Remove(item);
        }

        public int UpdateItem(T item)
        {
            var entity = Items.FirstOrDefault(p => p.Id == item.Id);
            if (entity != null) 
            {
                entity = item;
            }
            return entity.Id;
        }

        public int GetLastId()
        {
            int lastId;
            if (Items.Any())
            {
                lastId = Items.OrderBy(p => p.Id).LastOrDefault().Id;
            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }

        public T GetItemById(int id)
        {
            var entity = Items.FirstOrDefault(p => p.Id == id);
            return entity;
        }
    }
}
