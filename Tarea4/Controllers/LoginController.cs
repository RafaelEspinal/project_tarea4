using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea4.Models;

namespace Tarea4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(datos data, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                string nombreFoto = imagen.FileName;

                imagen.SaveAs(Server.MapPath("/img/" + nombreFoto));


                @ViewBag.foto = nombreFoto;

                return View("Resivir", data);
            }
            else
            {

                return View("Index");
            }
        }
        public ActionResult Resivir(datos data)
        {

            return View(data);
        }
    }
}