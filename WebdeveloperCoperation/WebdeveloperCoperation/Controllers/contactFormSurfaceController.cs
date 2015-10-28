using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebdeveloperCoperation.viewModel;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace WebdeveloperCoperation.Controllers
{
    public class contactFormSurfaceController : SurfaceController
    {
      public ActionResult Index()
      {
          return PartialView("contactForm", new contactForm());
      }
        [HttpPost]
      public ActionResult HandleFormSubmit(contactForm model)
      {
          if (!ModelState.IsValid) { return CurrentUmbracoPage(); }
 
          IContent comment = Services.ContentService.CreateContent(model.Subject, CurrentPage.Id, "comment");

          comment.SetValue("name", model.Name);
          comment.SetValue("email", model.Email);
          comment.SetValue("subject", model.Subject);
          comment.SetValue("message", model.Message);

          
          // For saving only
          Services.ContentService.Save(comment);
          TempData["success"] = true;
          // For saving and publishing
          //Services.ContentService.SaveAndPublishWithStatus(comment);
          
          
            
            return RedirectToCurrentUmbracoPage();

          
      }
    }

}

