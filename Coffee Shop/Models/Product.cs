﻿using System;
using System.Collections.Generic;

namespace Coffee_Shop.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? Catagory { get; set; }
    }
}
