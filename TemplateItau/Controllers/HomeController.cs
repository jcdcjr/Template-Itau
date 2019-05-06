using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TemplateItau.Controllers
{    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");

            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Home"));

            ViewBag.Breadcrumbs = breadcrumbs;

            return View();
        }

        private bool ValidaLogin()
        {
            if (Session.Count > 0)
            {
                return true;
            }
            else            
                return false;
        }

        private string CriarBreadcrumb()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<li class='breadcrumb-item'><a href='javascript: void(0)'>Home</a></li>");

            return sb.ToString();
        }
    }
}