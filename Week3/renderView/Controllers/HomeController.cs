using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace renderview {
    public class HomeController: Controller {
        [Route("/")]
        public IActionResult Index(){
            return View();
        }

        [Route("/info")]
        public IActionResult Info(){
            var Information = new Dictionary<string, object>();
            Information["Name"] = "Vincent Lai";
            Information["Address"] = "4600 N Clarendon Ave #502";
            Information["Phone"] = "773-548-5487";
            ViewBag.PhoneBook = Information;
            return View("info");

        }
    }
}