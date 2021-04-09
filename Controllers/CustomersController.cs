using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // Class Customer var
        List<Customer> customers = new List<Customer>

        {
            new Customer{ Name = "John Smith", Id = 1 },
            new Customer{ Name = "Mary Williams", Id = 2 }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Customers/Detail
        public ActionResult Detail(int id)
        {
            var viewModel = new CustomerDetailViewModel
            {
                Customers = customers,
                Id = id
            };

            return View(viewModel);
        }
    }
}