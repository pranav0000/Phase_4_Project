using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phase_4_Project_WDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase_4_Project_WDB.Controllers
{
    public class Customer : Controller
    {

        static List<Customer_Records> customer = new List<Customer_Records> 
        {
                new Customer_Records{CustomerId= 101, CustomerName ="Arvind",CustomerUname="Arvind@12", CustomerPwd="1234", CustomerEmail="Arvind@gmail.com"},
                new Customer_Records{CustomerId= 102, CustomerName ="Pranav",CustomerUname="Pranav@12", CustomerPwd="1234", CustomerEmail="Pranav@gmail.com"},
                new Customer_Records{CustomerId= 103, CustomerName ="Kiran",CustomerUname="Kiran@12", CustomerPwd="1234", CustomerEmail="Kiran@gmail.com"},
                new Customer_Records{CustomerId= 104, CustomerName ="Keshav",CustomerUname="Keshav@12", CustomerPwd="1234", CustomerEmail="Keshav@gmail.com"},
        };


        public IActionResult Index()
        {
            ViewBag.customer_list = customer;
            return View();
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer_Records ctmr)
        {
            string user_name_from_front_end = ctmr.CustomerUname;
            string password_from_front_end = ctmr.CustomerPwd;

            if (user_name_from_front_end != null)
            { 
                Customer_Records cus = customer.Single(x => x.CustomerUname == user_name_from_front_end);
                if (cus.CustomerPwd == password_from_front_end)
                {
                    return RedirectToAction("Index", "Pizza");
                }

                else
                {
                    ViewBag.msg = "Incorrect Username / Password";
                    return View();
                }
            }
            else
            {
                ViewBag.msg = "Please enter Credentials";
                return View();
            }

        }


    }
}
