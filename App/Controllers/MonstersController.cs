using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using App.Data;
using App.ViewModels;

namespace App.Controllers
{
    public class MonstersController : Controller
    {
        // GET: Monsters
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Index()
        {
            var monsters = MonstersRepoPattern.GetAllMonsters();
            var monstersList = new MonstersListViewModel(monsters);

            return View("Index", monstersList);
        }

        // GET: Monsters/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Monsters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monsters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Monsters/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Monsters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Monsters/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Monsters/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}