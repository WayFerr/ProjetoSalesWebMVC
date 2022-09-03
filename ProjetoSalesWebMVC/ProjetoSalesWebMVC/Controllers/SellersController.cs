using Microsoft.AspNetCore.Mvc;

namespace ProjetoSalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
