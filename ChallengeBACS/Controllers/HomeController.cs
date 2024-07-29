using Infrastructure.ViewModels.Request.Doctor;
using Microsoft.AspNetCore.Mvc;
using Models.Data;
using Services.Infrastructure.Interfaces;

namespace ChallengeBACS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
