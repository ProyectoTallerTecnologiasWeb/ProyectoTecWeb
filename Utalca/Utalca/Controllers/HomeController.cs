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
            var usuario = new Models.Usuario();
            usuario.Email = email;
            usuario.Password = password;

            if (email == "eortiz@utalca.cl" && password == "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            if (email == "eortiz@alumnos.utalca.cl" && password == "alumno")
            {
                return RedirectToAction("IndexAlumno", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

          
        }


    }
}