using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiMVC.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public string TodoProveedor()
        {
            return @"<ul>
                        <li>Proveedor1</li>
                        <li>Proveedor2</li>
                        <li>Proveedor3</li>
                        <li>Proveedor4</li>
                     </il>";
        }
    }
}