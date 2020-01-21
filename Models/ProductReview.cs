using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class ProductReview : Base
    {
        public string Title { get; set; }
        public string Post { get; set; }

        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
