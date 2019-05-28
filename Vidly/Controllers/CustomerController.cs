using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private readonly VidlyDataContext _vidlyContext;
        public CustomerController()
        {
            _vidlyContext = new VidlyDataContext();
        }

        protected override void Dispose(bool disposing)
        {
            _vidlyContext.Dispose();
        }
        // GET: Customer
        public ViewResult Index()
        {
            var customers = _vidlyContext.Customers.Include(c => c.MemberShipType);
            return View(customers);
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            var customer=  _vidlyContext.Customers.Include(c =>c.MemberShipType).Where(x => x.Id == Id).FirstOrDefault();
            return View(customer);
        }
    }
}