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
        public List<T> Jobs { get; set; }

        public BaseService ()
        {
            Jobs = new List<T> ();
        }
        public List<T> GetAllJobs()
        {
            return Jobs;
        }
        public int AddJob(T job)
        {
            Jobs.Add(job);
            return job.Id;
        }
        public void RemoveJob(T job)
        {
            Jobs.Remove(job);
        }

        public int UpdateJob(T job)
        {
            var entity = Jobs.FirstOrDefault(p => p.Id == job.Id);
            if (entity != null) 
            {
                entity = job;
            }
            return entity.Id;
        }
    }
}
