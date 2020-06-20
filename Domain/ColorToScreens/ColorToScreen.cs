using Domain.Colors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ColorToScreens
{
    public class ColorToScreen
    {
        [Key]
        public int Id { get; set; }
        public Color Color { get; set; }
        //public Offer offer { get; set; }
    }
}
