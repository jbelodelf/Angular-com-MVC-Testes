using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAngular.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AngularTeste()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AngularTeste(teste testeModel)
        {
            var teste = 1 + 1;
            return View();
        }


    }

    public class teste
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}