using System;
using Wincubate.CS10.Part1.Data.Employees;

namespace Wincubate.CS10.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository repository = new EmployeeRepository();
            foreach (var employee in repository.GetAll())
            {
                string evalution = employee switch
                {
                    (not ProjectManager) and (not StudentProgrammer) => "Codes a little",
                    _ => "Probably codes a bit more..."
                };
                Console.WriteLine($"{employee.FullName}: {evalution}");
            }
        }
    }
}