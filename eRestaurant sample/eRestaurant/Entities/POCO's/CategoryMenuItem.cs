﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities.POCO_s
{
    public class CategoryMenuItem
    {
        public string CategoryDescription { get; set; }

        public string ItemDescription { get; set; }

        public decimal Price { get; set; }

        public int? Calories { get; set; }

        public string Comment { get; set; }
    }
}
