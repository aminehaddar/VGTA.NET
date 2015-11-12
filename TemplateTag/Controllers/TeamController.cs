using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VGTA.Data.Models;
using VGTA.Service;

namespace TemplateTag.Controllers
{
    public class TeamController : Controller
    {
        ITeamService iserviceTeam = null;
        public TeamController()
        {
            iserviceTeam = new TeamService();
        }
        // GET: Team
        public ActionResult Index()
        {
            
            return View(iserviceTeam.GetMany());
        }

        // GET: Team/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
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

        // GET: Team/Edit/5
        public ActionResult Edit(int id)
        {
            team t = iserviceTeam.GetById(id);

            return View(t);
        }

        // POST: Team/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_team,name,max_numbers")] team t)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    iserviceTeam.Update(t);
                    iserviceTeam.Commit();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(t);
            }
        }
      
        // GET: Team/Delete/5
        public ActionResult Delete(int id)
        {
            team t = iserviceTeam.GetById(id);

            iserviceTeam.Delete(t);
            iserviceTeam.Commit();
            return RedirectToAction("Index");

        }

        // POST: Team/Delete/5
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
