﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MiModeloMVC;
using MiModeloMVC.Models;

namespace MiModeloMVC.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Clientes> empList = new List<Clientes>
        {
            new Clientes
            {
                ID=1,
                Nombre="Bruno",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                Edad=25
            },
            new Clientes
            {
                ID=1,
                Nombre="Adrian",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                Edad=24
            },
        };

        // GET: Clientes
        public ActionResult Index()
        {
            var Clientes = from e in empList
                           orderby e.ID
                           select e;
            return View(Clientes);

        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            List<Clientes> empList = TodosLosClientes();

            var clientes = empList.Single(m => m.ID == id);//variable que contiene clientes a la cual le decimos que no seleccione el registro del modelo y que si es igual el id nos muestre la vista clientes
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var clientes = empList.Single(m => m.ID == id);
                    if (TryUpdateModel(clientes))
                    return RedirectToAction("Index");
                return View(clientes);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Clientes>TodosLosClientes()
        {
            return new List < Clientes >
            {

                new Clientes
                {
                    ID = 1,
                    Nombre = "Bruno",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 25
                },

                new Clientes
                {
                    ID = 12,
                    Nombre = "Adrian",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 24
                },
            };
        }
    }
}
