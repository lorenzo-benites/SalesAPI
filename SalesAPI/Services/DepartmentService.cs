using SalesAPI.Data;
using SalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SalesAPI.Services
{
    public class DepartmentService
    {
        private readonly SalesAPIContext _context;
        
        public DepartmentService(SalesAPIContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllDepartmentsAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
