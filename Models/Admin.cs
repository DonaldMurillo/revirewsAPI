﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revirewsAPI.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        

    }
}