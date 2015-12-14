using Fabstox_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Fabstox_Website.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        public ActionResult Index() {
            return PartialView("View",new ContackInfo());
        }


    }
}