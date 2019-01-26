﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyPOS.Data.Entity;

namespace MyPOS.Controllers
{
    public class RolesController : Controller
    {
        private Pos1Entities db = new Pos1Entities();

        // GET: Roles
        public ActionResult Index()
        {
            return View(db.ROLEs.ToList());
        }

        // GET: Roles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ROLE rOLE = db.ROLEs.Find(id);
            if (rOLE == null)
            {
                return HttpNotFound();
            }
            return View(rOLE);
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRole,nameRole")] ROLE rOLE)
        {
            if (ModelState.IsValid)
            {
                db.ROLEs.Add(rOLE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rOLE);
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ROLE rOLE = db.ROLEs.Find(id);
            if (rOLE == null)
            {
                return HttpNotFound();
            }
            return View(rOLE);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRole,nameRole")] ROLE rOLE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rOLE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rOLE);
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ROLE rOLE = db.ROLEs.Find(id);
            if (rOLE == null)
            {
                return HttpNotFound();
            }
            return View(rOLE);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ROLE rOLE = db.ROLEs.Find(id);
            db.ROLEs.Remove(rOLE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
