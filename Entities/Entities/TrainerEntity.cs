﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TrainerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public bool IsActive { get; set; }
    }
}
