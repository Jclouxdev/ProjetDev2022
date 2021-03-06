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
    public class HeroesController : Controller
    {
        private readonly IRepository<Hero> _heroRepository;

        public HeroesController(IRepository<Hero> heroRepository)
        {
            _heroRepository = heroRepository;
        }

        // GET: Heroes
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Index()
        {
            var heroes = _heroRepository.GetAll();
            var heroList = new HeroListViewModel(heroes);

            return View("Index", heroList);
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Heroes/Create
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

        // GET: Heroes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Heroes/Edit/5
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

        // GET: Heroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Heroes/Delete/5
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