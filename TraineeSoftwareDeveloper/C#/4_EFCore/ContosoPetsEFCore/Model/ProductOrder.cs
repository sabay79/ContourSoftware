﻿namespace ContosoPetsEFCore.Model
{
    public class ProductOrder
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}