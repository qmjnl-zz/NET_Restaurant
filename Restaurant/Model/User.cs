using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Model
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public List<Order> Order { get; set; }
    }
}
