﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class DishRepository : GenericRepository<Dish>
    {
        public DishRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
