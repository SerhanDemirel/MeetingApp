using MeetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetApp.Controllers
{
    public class MeetingController1 : Controller
    {
        
        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo user)
        {
            if (ModelState.IsValid)
            {
              Repository.CreateUser(user);
              ViewBag.UserCount = Repository.Users.Where(info=> info.WillAttend == true).Count();
              return View("Thanks",user );
            }
            else
            {
                return View(user);
            }
            
        }
        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }
        [HttpGet]
        public IActionResult Details (int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
