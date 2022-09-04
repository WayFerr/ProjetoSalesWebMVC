using ProjetoSalesWebMVC.Data;
using ProjetoSalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSalesWebMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoSalesWebMVCContext _context;

        public SellerService(ProjetoSalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
