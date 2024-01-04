using MeetApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetApp.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult Index()
        {
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            int saat = DateTime.Now.Hour; 
          //ViewBag.Selamlama = saat > 12 ? "Iyi gunler" : "Gunaydin";
          //ViewBag.Username = "Serhan";
            ViewData["Selamlama"] = saat > 12 ? "Iyi Gunler" : "Gunaydin";
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul , ABCKONGRE MERKEZI",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = 100

            };
            return View(meetingInfo);
        }
    }
}
