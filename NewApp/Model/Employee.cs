using Your_Namespace;

namespace NEWAPP.Model
{
    public class Employee
    {
public class Employee : Person
{
    public string EmployeeCode { get; set; }
}
public void EnterData()
{
    base.EnterData();
    System.Console.Write("Employee Code = ");
    EmployeeCode = Console.ReadLine();
}
public void Display()
{
    base.Display();
    System.Console.Write("- manhanvien: {0}", EmployeeCode);
}
    }
}

