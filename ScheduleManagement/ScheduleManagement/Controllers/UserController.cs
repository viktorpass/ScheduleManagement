using Microsoft.AspNetCore.Mvc;

namespace ScheduleManagement.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller {

        [HttpGet]
        public IActionResult Login() {
            return View();
        }
    }
}
