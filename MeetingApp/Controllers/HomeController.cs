using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int userCount = Repository.Users.Where(i => i.WillAttend).Count();
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Conference Room A",
                Date = DateTime.Now,
                NumberOfPeople = userCount
            };

            return View(meetingInfo);
        }
    }
}
