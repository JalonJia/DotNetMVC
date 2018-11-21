﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private LinqValueCalculator calc;

        public ShoppingCart(LinqValueCalculator calcParm)
        {
            calc = calcParm;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }

    }
}