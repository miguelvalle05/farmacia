using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class FacturasController : Controller
    {
        // GET: Facturas
        public ActionResult facturasProv()
        {
            return View();
        }
    }
}