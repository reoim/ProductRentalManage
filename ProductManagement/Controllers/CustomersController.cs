using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = this.GetCustomer();   
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = this.GetCustomer().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
                       {
                           new Customer() { Id = 1, Name = "John Smith" },
                           new Customer() { Id = 2, Name = "Mary Williams" }
                       };
        }
         
    }
}