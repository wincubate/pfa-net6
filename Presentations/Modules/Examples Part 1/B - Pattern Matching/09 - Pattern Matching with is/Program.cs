using System.Collections.Generic;
using Wincubate.CS10.Part1.Data.Employees;
using static System.Console;

namespace Wincubate.CS10.Part1.Slide09
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> all = repository.GetAll();

            foreach (Employee e in all)
            {
                //For software engineers:
                //
                //WriteLine($"{se.FullName} has produced {se.CodeLinesProduced} lines of C#");
            }
        }
    }
}
