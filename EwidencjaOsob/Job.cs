using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Client { get; set; }
        public string StartDate { get; set; }
    }
}
