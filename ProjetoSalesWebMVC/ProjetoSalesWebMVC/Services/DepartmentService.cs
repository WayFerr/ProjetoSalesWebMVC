using ProjetoSalesWebMVC.Data;
using ProjetoSalesWebMVC.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoSalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSalesWebMVCContext _context;

        public DepartmentService(ProjetoSalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
