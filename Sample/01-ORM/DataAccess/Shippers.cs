﻿using System;
using System.Collections.Generic;

namespace Sample.ORM.DataAccess
{
    public partial class Shippers
    {
        public Shippers()
        {
            Orders = new HashSet<Orders>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
