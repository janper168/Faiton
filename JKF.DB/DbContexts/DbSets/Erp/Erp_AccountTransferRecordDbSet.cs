﻿using JKF.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKF.DB.DbContexts
{
    public partial class BaseDbContext
    {
        public DbSet<Erp_AccountTransferRecord> Erp_AccountTransferRecord { get; set; }
    }
}