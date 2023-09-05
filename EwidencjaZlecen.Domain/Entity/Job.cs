﻿using EwidencjaZlecen.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen.Domain.Entity
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string Client { get; set; }

        public Job(int id, string name, int typeId)
        {
            Name = name;
            TypeId = typeId;
        }
    }
}