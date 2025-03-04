﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }        
        public bool? IsAdmin { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
    }
}
