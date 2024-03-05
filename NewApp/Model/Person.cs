namespace NEWAPP.Model
{
    public class Person
    {
public string FullName { get; set; }
public string Address { get ;set; }
public void EnterData()
{
    System.Console.Write("Full Name = ");
    FullName = Console.ReadLine();
    System.Console.Write("Address = " );
    Address = Console.ReadLine();
}
public void Display()
    {
    System.Console.WriteLine("{0} -{1}", FullName, Address);
}
    }
}
