﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
    }
}
