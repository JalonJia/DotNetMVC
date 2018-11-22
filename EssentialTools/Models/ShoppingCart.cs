using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private IValueCalculater calc;

        public ShoppingCart(IValueCalculater calcParm) { calc = calcParm; }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }

    }
}