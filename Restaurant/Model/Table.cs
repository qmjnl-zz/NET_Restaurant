using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Model
{
    class Table
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int PersonCount { get; set; }

        public List<Order> Orders { get; set; }
    }
}
