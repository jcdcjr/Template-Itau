using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateItau.Controllers
{    
    public class AutenticacaoController : Controller
    {        
        // GET: Autenticacao
        public ActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Funcional, string Senha)
        {
            if(!string.IsNullOrEmpty(Funcional) && !string.IsNullOrEmpty(Senha))
            {
                if (Funcional != "012345678")
                {
                    ModelState.AddModelError(string.Empty, "Funcional invalida");
                    return View();
                }
                if(Senha != "1234")
                {
                    ModelState.AddModelError(string.Empty, "Senha invalida");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Informe a funcional e/ou senha");
                return View();
            }

            Session["Funcional"] = Funcional;
            Session["RACF"] = "ABCDEFG";            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            
            Session.Abandon();
            return RedirectToAction("Login", "Autenticacao");
        }
    }
}