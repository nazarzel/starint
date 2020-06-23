using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Starint.Data.Colors
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
