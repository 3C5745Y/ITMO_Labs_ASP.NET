using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebApp.DAL;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class InternController : Controller
    {
        private InternshipsContext db = new InternshipsContext();

        // GET: Intern
        public ActionResult Index()
        {
            return View(db.Interns.ToList());
        }

        // GET: Intern/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return HttpNotFound();
            }
            return View(intern);
        }

        // GET: Intern/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Intern/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstName,EnrollmentDate")] Intern intern)
        {
            if (ModelState.IsValid)
            {
                db.Interns.Add(intern);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(intern);
        }

        // GET: Intern/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return HttpNotFound();
            }
            return View(intern);
        }

        // POST: Intern/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstName,EnrollmentDate")] Intern intern)
        {
            if (ModelState.IsValid)
            {
                db.Entry(intern).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(intern);
        }

        // GET: Intern/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return HttpNotFound();
            }
            return View(intern);
        }

        // POST: Intern/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Intern intern = db.Interns.Find(id);
            db.Interns.Remove(intern);
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
