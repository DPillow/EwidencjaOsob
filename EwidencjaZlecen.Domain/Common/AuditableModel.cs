using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen.Domain.Common
{
    public class AuditableModel
    {
        public int CreatedById { get; set; }
        public int UpdatedById { get; set;}
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set;}
    }
}
