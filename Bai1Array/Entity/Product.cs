﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Array.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
