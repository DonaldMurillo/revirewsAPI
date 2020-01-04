using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class Tag : Base 
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Scale { get; set; }

        public Tag() { }
    }
}
