﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inivohacks.DAL.Models
{
    public class Manufacturer
    {
        
        public int ManufacturerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NotifyEmail { get; set; }
        public int NotifySMS { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
