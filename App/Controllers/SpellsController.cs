using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using App.Data;
using App.Models;
using App.ViewModels;

namespace App.Controllers
{
    public class SpellsController : Controller
    {
        private readonly IRepository<Spell> _spellRepository;

        public SpellsController(IRepository<Spell> spellRepository)
        {
            _spellRepository = spellRepository;
        }

        // GET: Spells
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Index()
        {
            var spells = _spellRepository.GetAll();
            var spellsList = new SpellsListViewModel(spells);

            return View("Index", spellsList);
        }

        // GET: Spells/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Spells/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spells/Create
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

        // GET: Spells/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Spells/Edit/5
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

        // GET: Spells/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Spells/Delete/5
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