using Domain.Offers;
using Domain.OrderDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public List<Offer> Offers { get; set; }
        public string Message { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string CorporationAddress1 { get; set; }
        public string CorporationAddress2 { get; set; }
        public string CorporationZipCode { get; set; }

        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryZipCode { get; set; }

        public int DeliveryId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalSum { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public DateTime OrderPlaced { get; set; }

    }
}
