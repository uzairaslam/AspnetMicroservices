﻿namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string username)
        {
            UserName = username;
        }

        public decimal TotalPrice
        {
            get
            {
                return Items == null || Items.Count() == 0 ? 0 : Items.Sum(i => i.Price);

            }
        }
    }
}
