using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Pedidos()
        {
            return View();
        }

        public ActionResult GenerarPedido()
        {
            return View();
        }
    }
}