using Microsoft.AspNetCore.Mvc;
using ProjetoSalesWebMVC.Models;
using System.Collections.Generic;

namespace ProjetoSalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department() { ID = 1, Name = "Electronics" });
            list.Add(new Department() { ID = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
