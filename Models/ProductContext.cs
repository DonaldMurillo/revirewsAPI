﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class ProductContext : DbContext
    {

        public ProductContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
