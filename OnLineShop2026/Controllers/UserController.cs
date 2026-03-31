using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new User
            {
                FullName = "Алина Бзыкова",
                Email = "bzykovaaa@gmail.com"
            };

            return View(user);
        }
    }
}