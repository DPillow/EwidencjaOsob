using EwidencjaZlecen.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen.App.Abstract
{
    public interface IJobService
    {
        List<Job> GetItemByClient(string clientName);
    }
}
