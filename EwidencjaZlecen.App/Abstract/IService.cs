using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EwidencjaZlecen.Domain.Common;

namespace EwidencjaZlecen.App.Abstract  //w abstract wrzucamy interfejsy
{
    public interface IService <T>// Generyczny interfejs
    {
        List<T> Items { get; set; }
        List<T> GetAllItems();
        int AddItem(T job);
        int UpdateItem(T job);
        void RemoveItem(T job);
        int GetLastId();
        T GetItemById(int id);

    }
}
