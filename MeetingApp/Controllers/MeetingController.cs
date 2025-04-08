using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Thanks()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo user)
        {
            //Console.WriteLine(user.Name);
            //Console.WriteLine(user.Phone);
            //Console.WriteLine(user.Email);
            //Console.WriteLine(user.WillAttend);

            if (ModelState.IsValid)
            {
                Repository.CreateUser(user);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("Thanks", user);
            }
            else
            {
                return View();
            }
        }
        public IActionResult List()
        {
            return View(Repository.Users);
        }
        [Route("meeting/details/{id}")]
        public IActionResult Details(int id)
        {
            return View(Repository.getById(id));
        }
    }
}
