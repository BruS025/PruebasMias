﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Este es mi controlador Home";
        }

        [ActionName ("Hora")]
        
        public string HoraActual()
        {
            return CadenaHora();
        }

        [NonAction]
        public string CadenaHora()
        {
            return "son las" + DateTime.Now.ToString("T");
        }

    }
}