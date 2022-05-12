using App.Models;
using App.ViewModels;
using App.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        [HttpGet]
        [Route("Register")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("Register")]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CreatePlayerRequest player)
        {
            try
            {
                if(ModelState.IsValid){
                // TODO: Add insert logic here
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}