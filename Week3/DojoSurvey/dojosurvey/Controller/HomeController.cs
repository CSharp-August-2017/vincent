using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace dojosurvey.controllers{
    public class HomeController: Controller {
        [Route("/")]
        public IActionResult home(){
            return View();
        }

        [Route("result")]
        [HttpPost]
        public IActionResult result(string FullName, string LocationField, string ProgrammingField, string comment)
        {
            var FormRespond = new Dictionary<string, object>();
            FormRespond["Name"] = FullName;
            FormRespond["Location"] = LocationField;
            FormRespond["Language"] = ProgrammingField;
            FormRespond["comment"] = comment;
            ViewBag.Respond = FormRespond;
            return View();
        }
    }
}