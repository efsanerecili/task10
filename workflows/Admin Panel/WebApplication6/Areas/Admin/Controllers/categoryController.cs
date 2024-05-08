using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Areas.Admin.Controllers
{
    public class categoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
