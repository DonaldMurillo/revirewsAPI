using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class ProductTagContext :DbContext
    {
        public ProductTagContext(DbContextOptions<ProductTagContext> options) : base(options)
        {

        }

        public DbSet<ProductTag> ProductTags { get; set; }

    }
}
