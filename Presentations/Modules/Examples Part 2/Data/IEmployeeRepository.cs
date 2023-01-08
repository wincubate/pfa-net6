namespace Wincubate.CS10.Part3.Data;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll();
    void Add(Employee employee);
}
