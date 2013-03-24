using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeewons.Admin.Models.UserManageMent;

namespace Zeewons.Admin.Controllers
{
    public class UserManagementController : Controller
    {
        //
        // GET: /UserManagement/

        public ActionResult Register()
        {
            ViewBag.check = "hei";
            
            return View();
        }
        [HttpPost]
        public ActionResult Register(  RegisterModel model)
        {
            if (ModelState.IsValid) { 
            
            }
            ViewBag.check = "changed";
            return View("AfterRegister");
 
        }

    }
}
