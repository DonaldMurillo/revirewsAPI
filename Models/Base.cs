using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class Base
    {
        public long Id { get; set; }
        
        public int AdminsId { get; set; }
        [ForeignKey("AdminsId")]
        public Admin Admin { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; }


    }
}
