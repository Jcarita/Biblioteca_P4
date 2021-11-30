using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca_Web.Models;
using System.Net;
using System.Data;


namespace Biblioteca_Web.Controllers
{
    public class PrestamoController : Controller
    {
        private BibliotecaEntities _contexto;

        public BibliotecaEntities contexto
        {
            set { _contexto = value; }

            get
            {
                if (_contexto == null)
                    _contexto = new BibliotecaEntities();
                return _contexto;
            }
        }
        // GET: Prestamo
        public ActionResult Index()
        {
            return View(contexto.Prestamoes.ToList());
        }
        public ActionResult CreatePrestamo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePrestamo(Prestamo createPrestamo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Prestamoes.Add(createPrestamo);
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(createPrestamo);
            }
            catch
            {
                return View();
            }
            return View();
        }
        public ActionResult EditarPrestamo(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Prestamo prestamoEditar = contexto.Prestamoes.Find(id);

            if (prestamoEditar == null)
                return HttpNotFound();

            return View(prestamoEditar);
        }

        [HttpPost]
        public ActionResult EditarPrestamo(Prestamo prestamoEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Entry(prestamoEditar).State = EntityState.Modified;
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(prestamoEditar);
            }
            catch
            {
                return View();
            }
            
        }

        public ActionResult EliminarPrestamo(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Prestamo prestamoEliminar = contexto.Prestamoes.Find(id);
            if (prestamoEliminar == null)
                return HttpNotFound();
            contexto.Entry(prestamoEliminar).State = EntityState.Deleted;
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}