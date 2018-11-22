using EssentialTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

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
            //IValueCalculater calc = new LinqValueCalculator();
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculater>().To<LinqValueCalculator>();
            IValueCalculater calc = ninjectKernel.Get<IValueCalculater>();

            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalvalue = cart.CalculateProductTotal();
            return View(totalvalue);
        }
    }
}