﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiMVC.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode(nombre);
            return Content(input);
        }

        [HttpGet]
        public ActionResult Buscar()
        {
            var input = "Este es el selector http GET";
            return Content(input);
        }
    }
}