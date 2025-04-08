using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Conference Room A",
                Date = DateTime.Now,
                NumberOfPeople = 10
            };

            return View(meetingInfo);
        }
    }
}
