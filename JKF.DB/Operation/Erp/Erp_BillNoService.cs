﻿using JKF.DB.DbContexts;
using JKF.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKF.DB.Operation
{
    public class Erp_BillNoService : BaseService<Erp_BillNo>
    {
        public Erp_BillNoService(BaseDbContext baseDbContext) : base(baseDbContext) { }
    }
}