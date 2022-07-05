using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;
using App.Data;
using App.Models;
using App.ViewModels;

namespace App.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPlayerRepository<Player> _playerRepository;
        public AccountController(IPlayerRepository<Player> playerRepository){
            _playerRepository = playerRepository;
        }

        [HttpGet]
        [Route("[controller]")]
        // GET: Account
        public ActionResult Index()
        {
            Player player = _playerRepository.GetByUname(User.Identity.Name);
            UserProfile currentUser = new UserProfile{
                UserName = player.Name,
                CreationDate = player.CreationDate,
                Email = player.Email
            };
            return View("Index", currentUser);
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
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

        // GET: Account/EditEmail/admin
        [HttpGet]
        [Route("[controller]/EditEmail/{name}")]
        public ActionResult EditEmail(string name)
        {
            return View("Edit-Email");
        }

        // POST: Account/Edit/Email/admin
        [HttpPost]
        [Route("[controller]/EditEmail/{name}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmail(string email, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var player = _playerRepository.GetByUname(User.Identity.Name);
                player.Email = email;
                _playerRepository.UpdatePlayer(player);
                _playerRepository.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Account/EditPassword/admin
        [HttpGet]
        [Route("[controller]/EditPassword/{name}")]
        public ActionResult EditPassword(string name)
        {
            return View("Edit-Password");
        }

        // POST: Account/Edit/Password/admin
        [HttpPost]
        [Route("[controller]/EditPassword/{name}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPassword(int id, IFormCollection collection)
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
        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
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