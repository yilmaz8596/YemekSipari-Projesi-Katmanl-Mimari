﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Cart : BaseEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }
        public User? User { get; set; } 

    }
}
