using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject(new AlgorithmB());
        subject.CallAlgorithm();

        EmployeeList employees = new EmployeeList();
        employees.Add(new Employee("Bill", 550000));
        employees.Add(new Employee("Bob", 420000));
        employees.Add(new Employee("Steve", 1550000));
        employees.Add(new Employee("Jim", 245000));

        employees.SetSortStrategy(new SortBySalary());
        employees.Sort();
    }
}
