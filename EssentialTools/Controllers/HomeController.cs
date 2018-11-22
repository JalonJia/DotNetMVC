﻿using EssentialTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
        {
            new Product {Name = "Kayak", Category="Watersports", Price=275M},
            new Product {Name = "LifeJaket", Category="Watersports", Price=48.95M},
            new Product {Name = "Soccer ball", Category="Soccer", Price=19.50M},
            new Product {Name = "Corner Flag", Category="Soccer", Price=34.95M}
        };

        // GET: Home
        public ActionResult Index()
        {
            LinqValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalvalue = cart.CalculateProductTotal();
            return View(totalvalue);
        }
    }
}