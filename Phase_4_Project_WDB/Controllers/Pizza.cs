using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phase_4_Project_WDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase_4_Project_WDB.Controllers
{
    public class Pizza : Controller
    {

        static List<Pizza_Records> pizza_cart_list = new List<Pizza_Records>();
        static List<Pizza_Records> pizza = new List<Pizza_Records>
        
        {
                new Pizza_Records{PizzaId= 111, PizzaName ="Paneer & Onion",PizzaImage="https://tinyurl.com/285ctzua", PizzaPrice=120 },
                new Pizza_Records{PizzaId= 112, PizzaName ="Veg Loaded",PizzaImage="https://tinyurl.com/285ctzua", PizzaPrice=130 },
                new Pizza_Records{PizzaId= 113, PizzaName ="Corn & Cheese",PizzaImage="https://tinyurl.com/285ctzua", PizzaPrice= 250  },
                new Pizza_Records{PizzaId= 114, PizzaName ="Chicken Sausage",PizzaImage="https://tinyurl.com/285ctzua", PizzaPrice=210 },
                new Pizza_Records{PizzaId= 115, PizzaName ="Veg Farmhouse",PizzaImage="https://tinyurl.com/285ctzua", PizzaPrice=310 },
                new Pizza_Records{PizzaId= 116, PizzaName ="Nov-Veg Loaded",PizzaImage="https://tinyurl.com/285ctzua", PizzaPrice=380 },
        };

        public IActionResult Index()
        {
            
            ViewBag.pizza_list = pizza;
            return View();
        }

        public IActionResult pizza_details(int id)
        {
            var show_one_pizza = pizza.Single(x => x.PizzaId == id);
            return View(show_one_pizza);
        }

       /* [HttpGet]
        public IActionResult order_cart()
        {
            pizza_cart_list = null;
            return View();
        }*/

        /*[HttpPost]*/

        //Adding to cart featurek
        public ActionResult order_cart(int id)
        {
            int total_amount = 0;
            Pizza_Records new_pizza = pizza.Single(x => x.PizzaId == id);
            int index = new_pizza.PizzaId;
            pizza_cart_list.Add(new_pizza);

            // Total sum of laptops
            for (int j = 0; j < pizza_cart_list.Count; j++)
            {
                total_amount += pizza_cart_list[j].PizzaPrice;
            }


            ViewBag.list = pizza_cart_list;
            ViewBag.price = total_amount;
            return View();
        }

        //Order Confirmation View
        public IActionResult order_confirm()
        {
            return View();
        }
    }

}