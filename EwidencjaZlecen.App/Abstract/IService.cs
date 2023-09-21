using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EwidencjaZlecen.Domain.Common;
using EwidencjaZlecen.Domain.Entity;

namespace EwidencjaZlecen.App.Abstract  //w abstract wrzucamy interfejsy
{
    public interface IService <T>// Generyczny interfejs
    {
        public List<T> Items { get; set; }
        List<T> GetAllIItems();
        int AddItem(T item);
        int UpdateItem(T item);
        void RemoveItem(T item);
        int GetLastId();
        T GetItemById(int id);
    }
}
