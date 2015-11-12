using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VGTA.Data.Models;

namespace TemplateTag.Controllers
{
    public class gamersController : Controller
    {
        private vgtaContext db = new vgtaContext();

        // GET: gamers
        public ActionResult Index()
        {
            var gamers = db.gamers.Include(g => g.team1.id_team);
            return View(gamers.ToList());
        }

        // GET: gamers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gamer gamer = db.gamers.Find(id);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // GET: gamers/Create
        public ActionResult Create()
        {
            ViewBag.team = new SelectList(db.teams, "id_team", "name");
            return View();
        }

        // POST: gamers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,accepted,age,email,firstName,hasVoted,image,lastName,numtel,pwd,rank,record,role,team")] gamer gamer)
        {
            if (ModelState.IsValid)
            {
                db.gamers.Add(gamer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.team = new SelectList(db.teams, "id_team", "name", gamer.team);
            return View(gamer);
        }

        // GET: gamers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gamer gamer = db.gamers.Find(id);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            ViewBag.team = new SelectList(db.teams, "id_team", "name", gamer.team);
            return View(gamer);
        }

        // POST: gamers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,accepted,age,email,firstName,hasVoted,image,lastName,numtel,pwd,rank,record,role,team")] gamer gamer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gamer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.team = new SelectList(db.teams, "id_team", "name", gamer.team);
            return View(gamer);
        }

        // GET: gamers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gamer gamer = db.gamers.Find(id);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // POST: gamers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            gamer gamer = db.gamers.Find(id);
            db.gamers.Remove(gamer);
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
