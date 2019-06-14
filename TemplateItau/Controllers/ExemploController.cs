using System.Collections.Generic;
using System.Web.Mvc;

namespace TemplateItau.Controllers
{
    public class ExemploController : Controller
    {
        #region UI
        public ActionResult Alertas()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");

            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Alerts"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion


            return View();
        }

        public ActionResult Arvores()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");

            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "TreeViews"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion

            return View();
        }

        public ActionResult BarrasProgresso()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");

            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "ProgressBar"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }

        public ActionResult Botoes()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");

            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Buttons"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion

            return View();
        }

        public ActionResult Modals()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Modals"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }

        public ActionResult Notificacoes()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Notifications"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }

        public ActionResult Tabs()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Interface"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Tabs"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }
        #endregion

        #region forms
        public ActionResult DefaultForms()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Forms"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Default"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }

        public ActionResult DropzonesForms()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");

            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Forms"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Dropzone"));

            ViewBag.Breadcrumbs = breadcrumbs;

            #endregion
            return View();
        }

        public ActionResult PickerForms()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Forms"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Pickers"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion

            return View();
        }

        public ActionResult StepForms()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Forms"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Steps"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }

        public ActionResult UploadForms()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Forms"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Upload"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }

        #endregion

        #region Tables
        public ActionResult DataTable()
        {
            if (!ValidaLogin()) return RedirectToAction("Login", "Autenticacao");
            #region Breadcrumbs
            var breadcrumbs = new List<KeyValuePair<string, string>>();
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: document.location.href =\"/\"", "Home"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "Tables"));
            breadcrumbs.Add(new KeyValuePair<string, string>("javascript: void(0)", "DataTable"));

            ViewBag.Breadcrumbs = breadcrumbs;
            #endregion
            return View();
        }
        #endregion

        private bool ValidaLogin()
        {
            return Session != null && Session.Count > 0;
        }
    }
}