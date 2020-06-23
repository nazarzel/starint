
using Starint.Data.Categories;
using Starint.Data.Deliveries;
using Starint.Data.OfferColors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;

namespace Starint.Data.Offers
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal OldPrice { get; set; }
        public double Pitch { get; set; }
        public string ModuleSize { get; set; }
        public string Type { get; set; }
        public string WatchDistance { get; set; }
        public int IPType { get; set; }
        public string Size { get; set; }
        public int Brightness { get; set; }
        public string Communication { get; set; }
        public List<OfferColor> OfferColors { get; set; }
        public List<Delivery> Deliveries { get; set; }
        public string UrlImage1 { get; set; }
        public string UrlImage2 { get; set; }
        public string UrlImage3 { get; set; }
        public Category Category { get; set; }

    }
}
