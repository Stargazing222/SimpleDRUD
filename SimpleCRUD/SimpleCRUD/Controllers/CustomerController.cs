using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCRUD.Models;

namespace SimpleCRUD.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CRUDContext context = new CRUDContext();

        // GET: Customer
        public ActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }
    }
}