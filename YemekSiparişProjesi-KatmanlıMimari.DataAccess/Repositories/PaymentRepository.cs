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
    public class PaymentRepository : GenericRepository<Payment>
    {
        public PaymentRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
