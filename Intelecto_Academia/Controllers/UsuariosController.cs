using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intelecto_Academia.Controllers
{
    public class UsuariosController : Controller
    {
        //
        // GET: /Usuarios/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Cliente()
        {
            return View();
        }

        public ActionResult Novo_Cliente()
        {
            return View();
        }

        public ActionResult Colaborador()
        {
            return View();
        }

        public ActionResult Novo_Colaborador()
        {
            return View();
        }

        public ActionResult Login_Administrador()
        {
            return View();
        }
        
        public ActionResult Administrador()
        {
            return View();
        }

        public ActionResult Novo_Administrador()
        {
            return View();
        }


    }
}
