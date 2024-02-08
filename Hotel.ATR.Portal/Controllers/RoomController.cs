using Microsoft.AspNetCore.Mvc;

namespace Hotel.ATR.Portal.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoomList()
        {
            return View();
        }

        public IActionResult RoomDetails()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateSubscribe(string email)
        {
            return RedirectToAction("RoomDetails");
        }
    }
}
