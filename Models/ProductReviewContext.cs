using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class ProductReviewContext : DbContext
    {
        public ProductReviewContext(DbContextOptions<ProductReviewContext> options) : base(options)
        {

        }

        public DbSet<ProductReview> ProductReviews { get; set; }

    }
}
