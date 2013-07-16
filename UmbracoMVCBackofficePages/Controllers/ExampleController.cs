using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoMVCBackofficePages.Models;

namespace UmbracoMVCBackofficePages.Controllers
{
    public class ExampleController : UmbracoAuthorizedController
    {
        
        public ActionResult Index(int id)
        {
            var p = Data.GetById(id);

            PersonViewModel model = new PersonViewModel();
            model.Id = p.Id;
            model.FirstName = p.FirstName;
            model.LastName = p.LastName;

            return View("~/App_Plugins/UmbracoMVCBackofficePages/Views/Index.cshtml", model);
        }

        [HttpPost]
        public ActionResult Edit(PersonViewModel person)
        {
            if (ModelState.IsValid) { }
                //do something

            TempData["success"] = true;

            return View("~/App_Plugins/UmbracoMVCBackofficePages/Views/Index.cshtml",person);
        }

    }
}
