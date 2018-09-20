﻿using Project.Models;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    
    public class OrdersController : Controller
    {
        MyDatabaseEntities db = new MyDatabaseEntities();
        
        [Authorize]
        public ActionResult Index(string searchString)
        {
<<<<<<< HEAD
            List<Customer> OrderAndCustomerList = db.Customers.ToList();
            return View(OrderAndCustomerList);
        }
        
        public ActionResult GetInfPrint()
        {
            List<Customer> OrderAndCustomerList = db.Customers.ToList();
=======
            var OrderAndCustomerList = from m in db.Customers select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                OrderAndCustomerList = OrderAndCustomerList.Where(s => s.Name.Contains(searchString));
            }

>>>>>>> pqvy
            return View(OrderAndCustomerList);
        }

    }
}