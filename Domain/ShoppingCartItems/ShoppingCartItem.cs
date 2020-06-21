using Domain.Offers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ShoppingCartItems
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Offer Offer { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
