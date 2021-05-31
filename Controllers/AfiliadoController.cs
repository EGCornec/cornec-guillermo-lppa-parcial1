using cornec_guillermo_lppa_parcial1.Business;
using cornec_guillermo_lppa_parcial1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cornec_guillermo_lppa_parcial1.Controllers
{
    public class AfiliadoController : Controller
    {
        // GET: Afiliado
        public ActionResult Index()
        {
            Afiliado_biz Afiliado_biz = new Afiliado_biz();

            var lista = Afiliado_biz.Listar();

            return View(lista);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new Afiliado_biz();
            var model = biz.Get(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Producto_busi = new Afiliado_biz();
            var producto = Producto_busi.Get(id);
            if (producto == null)
            {
                return View();
            }

            return View(producto);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var Producto_busi = new Afiliado_biz();
            var producto = Producto_busi.Get(id);
            if (producto == null)
            {
                return View();
            }

            return View(producto);
        }


        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                var biz = new Afiliado_biz();
                biz.Agregar(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                /// Que pasa con el error -> Bitacoras
                Console.WriteLine(e);
                return View(model);
            }
        }
        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {
            var biz = new Afiliado_biz();
            biz.Eliminar(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Afiliado model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }
            var Producto_busi = new Afiliado_biz();
            Producto_busi.Update(model);

            return RedirectToAction("Index");
        }
    }
}