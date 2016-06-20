using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexAlumno()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var emailProfesor = "eortiz@utalca.cl";
            var pass = "admin";
            if (email == emailProfesor  && password == pass)
            {
                //controlador, accion
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("IndexAlumno", "Home");
            }
        }


    }
}