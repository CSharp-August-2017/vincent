using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace portfolio{
    public class HomeController: Controller {
        [Route("/")]
        public IActionResult Index(){
            var ContactInfo = new Dictionary<string, object>();
            ContactInfo["Name"] = "Vincent Lai";
            ContactInfo["Address"] = "4600 N Clarendon Ave #502, Chicago, IL 60640";
            ContactInfo["Phone"] = "630-935-4888";
            ViewBag.PhoneBook = ContactInfo;
            return View("index");
        }

        [Route("/projects")]
        public IActionResult Project(){
            var myProject1 = new Dictionary<object, string>();
            var myProject2 = new Dictionary<object, string>();
            var myProject3 = new Dictionary<object, string>();
            myProject1["Name"] = "Project 1: Huricane Harvey";
            myProject1["Image"] ="project1.jpg";
            myProject1["Description"] = "This project we are gathering food, supply to help Huricane Harvey Victim in Houston, Tx";
            myProject2["Name"] = "Project 2: Huricane Irma";
            myProject2["Image"] ="project2.jpg";
            myProject2["Description"] = "We are gathering food and supplies to help state of Florida - The aftermath Irma";
            myProject3["Name"] = "Project 3: Mexico 7.1 Earthquake";
            myProject3["Image"] ="project3.jpg";
            myProject3["Description"] = "Gathering food and supplies to help Mexico City";
            ViewBag.Project1 = myProject1;
            ViewBag.Project2 = myProject2;
            ViewBag.Project3 = myProject3;
            return View("project");
        }

        [Route("/contact")]
        public IActionResult Contact(){
            
            return View("contact");
        }
    }
}

