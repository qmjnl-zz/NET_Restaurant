using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Model
{
    class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime CompletionDate { get; set; }

        public int TableId { get; set; }
        public Table Table { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
