﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public decimal Cost { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Country}-{Cost}";
        }
    }
}
