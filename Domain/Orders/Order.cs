using Domain.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Orders
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CorporationName { get; set; }
        public string NIP { get; set; }
        public string PaymentType { get; set; }
        public IEnumerable<Offer> offers { get; set; }
        public string Message { get; set; }
        public string CorporationAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public int DeliveryId { get; set; }
        public double TotalSum { get; set; }


    }
}
