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
        List<T> Jobs { get; set; }
        List<T> GetAllJobs();
        int AddJob(T job);
        int UpdateJob(T job);
        void RemoveJob(T job);
    }
}
