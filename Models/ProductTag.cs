using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class ProductTag : Base
    {
        public long ProductID { get; set; }
        public Product Product { get; set; }
        public long TagID { get; set; }
        public Tag Tag { get; set; }

    }
}
