using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUD.Models
{
    public class Customer
    {
        public string Id { get; set; }

        public string  Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}