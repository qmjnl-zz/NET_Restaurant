using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Model
{
    class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}
