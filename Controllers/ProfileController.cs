using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
