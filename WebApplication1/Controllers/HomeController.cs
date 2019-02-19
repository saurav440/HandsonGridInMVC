using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        List<Client> clients = new List<Client>();

       
        public HomeController()
        {
            clients = new List<Client>{

            new Client { Id = 1, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com" },
            new Client { Id = 2, Name = "Juan Torres", Email = "jtorres@hotmail.com" },
            new Client { Id = 3, Name = "Oscar Camacho", Email = "oscar@hotmail.com" },
            new Client { Id = 4, Name = "Gina Urrego", Email = "ginna@hotmail.com" },
            new Client { Id = 5, Name = "Nathalia Ramirez", Email = "natha@hotmail.com" },
            new Client { Id = 6, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com" },
            new Client { Id = 7, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com" }

        };
        }

        public ActionResult Index()
        {
            return View(clients);
        }

        [HttpPost]
        public JsonResult SaveAll(string request)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }

    }
}