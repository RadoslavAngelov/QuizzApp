﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcTemplate.Data;
using MvcTemplate.Data.Models;
using MvcTemplate.Web.ViewModels.Quizzes;

namespace MvcTemplate.Web.Controllers
{
    public class QuizsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Quizs
        public ActionResult Index()
        {
            return View(db.Quizs.ToList());
        }

        // GET: Quizs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quiz quiz = db.Quizs.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        // GET: Quizs/Create
        public ActionResult Create()
        {
            ViewBag.CategorySelection = db.QuizCategories.Select(c => new SelectListItem
                                            {
                                                Value = c.Id.ToString(),
                                                Text = c.Name
                                            });
            return View();
        }

        // POST: Quizs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,CategoryID,CreatedOn,ModifiedOn,IsDeleted,DeletedOn")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.Quizs.Add(quiz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quiz);
        }

        // GET: Quizs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quiz quiz = db.Quizs.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        // POST: Quizs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,CategoryID,CreatedOn,ModifiedOn,IsDeleted,DeletedOn")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quiz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quiz);
        }

        // GET: Quizs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quiz quiz = db.Quizs.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        // POST: Quizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quiz quiz = db.Quizs.Find(id);
            db.Quizs.Remove(quiz);
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
