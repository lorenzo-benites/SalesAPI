using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesAPI.Data;
using SalesAPI.Models;

namespace SalesAPI.Services
{
    public class SellerService
    {
        private readonly SalesAPIContext _context;

        public SellerService(SalesAPIContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
