using System.Linq;
using LojaVirtual.Data;
using LojaVirtual.Models;
using System.Collections.Generic;

namespace LojaVirtual.Services
{
    public class DepartmentService
    {
        private readonly LojaVirtualContext _context;

        public DepartmentService(LojaVirtualContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(department => department.Nome).ToList();
        }
    }
}
