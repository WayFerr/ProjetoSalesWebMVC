using ProjetoSalesWebMVC.Data;
using ProjetoSalesWebMVC.Models;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoSalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSalesWebMVCContext _context;

        public DepartmentService(ProjetoSalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
