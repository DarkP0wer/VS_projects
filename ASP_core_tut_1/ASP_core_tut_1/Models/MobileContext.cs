﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_core_tut_1.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Oreders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options) : base(options)
        {

        }
    }
}
