using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public long CategoryId { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

    }
}
