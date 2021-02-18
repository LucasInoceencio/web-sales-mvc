using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Versão síncrona
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(or => or.Name).ToList();
        }

        // Versão assíncrona
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(or => or.Name).ToListAsync();
        }
    }
}
