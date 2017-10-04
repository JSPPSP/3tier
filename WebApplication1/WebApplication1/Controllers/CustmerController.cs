using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BAL.Repositry;
using Web.BAL.Repositry.Interface;
using Web.DTO.Model;

namespace WebApplication1.Controllers
{
    public class CustmerController : Controller
    {
        private readonly Icustmer _3TierArchitecure_Repositry;
        public CustmerController()
        {

            this._3TierArchitecure_Repositry = new CustmerRepositry();
        }
        // GET: Custmer
        public ActionResult AllCustmers()
        {
            var alldata = _3TierArchitecure_Repositry.GetCustmers().Where(c => c.CustmerId == id);
            return View(alldata);
        }

        // GET: Custmer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Custmer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Custmer/Create
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

        // GET: Custmer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Custmer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Custmer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Custmer/Delete/5
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
    }
}
