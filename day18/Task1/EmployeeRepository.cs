using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task<List<EmployeeModel>> GetEmployeesAsync(string currentUser)
        {
            return await _context.Employees
                .Include(e => e.Department)
                .Where(e => e.UserName == currentUser)
                .ToListAsync();
        }

        public async Task AddEmployeeAsync(EmployeeModel employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(EmployeeModel employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(EmployeeModel employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
}
