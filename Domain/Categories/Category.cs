using Domain.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Categories
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Offer> Offers { get; set; }

    }
}
