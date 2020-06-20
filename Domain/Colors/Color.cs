﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Colors
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
