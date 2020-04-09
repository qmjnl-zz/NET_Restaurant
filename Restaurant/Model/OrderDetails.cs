using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Model
{
    class OrderDetails
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int PortionCount { get; set; }
    }
}
