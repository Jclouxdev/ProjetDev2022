using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class LogoutController : Controller
    {
        [HttpPost]
        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("AuthCookie");
            return Redirect("/");
        }
    }
}