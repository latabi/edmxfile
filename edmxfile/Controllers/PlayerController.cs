using edmxfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace edmxfile.Controllers
{
    public class PlayerController : Controller
    {
        private testEntities5 _context = null;
        public PlayerController()
        {
            _context = new testEntities5();
        }
        // GET: Player
        public ActionResult Index()
        {
            var x = _context.Database.SqlQuery<Player>("exec sp_getplayer");
            return View(x);
        }
        public ActionResult multipletables()
        { 
            var x = _context.Database.SqlQuery<productcustomerjoin>("exec ProductCustomer");
          
            return View(x);
        }
        public ActionResult Partialexample( )
        {
            var x = _context.Database.SqlQuery<productcustomerjoin>("exec  ProductCustomer");

            return View(x);
        }

        public ActionResult CompanyEmployeeJoin()
        {
            var x = _context.Database.SqlQuery<joincompemp>("exec   sp_joincompemp");
            return View(x);
        }
        


        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
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

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Player/Edit/5
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

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Player/Delete/5
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
