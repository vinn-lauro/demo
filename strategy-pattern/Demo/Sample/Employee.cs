using System.Reflection.Metadata.Ecma335;

namespace Demo.Sample;

public class Employee
{
    private static int incrementId;
    public int Id;
    public string Name;
    public double Salary;

    public Employee(string name, double salary)
    {
        incrementId++;
        Id = incrementId;
        Name = name;
        Salary = salary;
    }
}

class EmployeeList
{
    private List<Employee> _list;
    private SortStrategy _sortStrategy;

    public void SetSortStrategy(SortStrategy sortStrategy) => _sortStrategy = sortStrategy;

    public void Add(Employee employee)
    {
        if (_list == null) _list = new List<Employee>();
        _list.Add(employee);
    }

    public void Sort() => _sortStrategy.Sort(_list);
}

abstract class SortStrategy
{
    public virtual void Sort(List<Employee> list)
    {
        if (list != null)
            foreach (Employee emp in list)
                Console.WriteLine("ID: {0} - Name: {1} - Salary: {2}", emp.Id, emp.Name, emp.Salary);
    }
}

class SortById : SortStrategy
{
    public override void Sort(List<Employee> list)
    {
        list = list.OrderByDescending(emp => emp.Id).ToList();
        base.Sort(list);
    }
}

class SortByName : SortStrategy
{
    public override void Sort(List<Employee> list)
    {
        list = list.OrderByDescending(emp => emp.Name).ToList();
        base.Sort(list);
    }
}

class SortBySalary : SortStrategy
{
    public override void Sort(List<Employee> list)
    {
        list = list.OrderByDescending(emp => emp.Salary).ToList();
        base.Sort(list);
    }
}