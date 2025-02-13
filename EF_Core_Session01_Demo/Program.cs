using EF_Core_Session01_Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Session01_Demo
{
    internal class Program
    {
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            //context.Employees.Where(E => E.EmpId == 0);

        }
    }
}
