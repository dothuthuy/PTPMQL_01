namespace NEWAPP.Model
{
    public class Employee
    {
public string manhanvien { get; set; }
public string Ten { get ;set; }
public int Tuoi { get; set; }
public string quequan { get; set; }
public void EnterData()
{
    System.Console.Write("manhanvien = ");
    masinhvien = Console.ReadLine();
    System.Console.Write("Ten = " );
    Ten = Console.ReadLine();
     System.Console.Write("Tuoi = ");
    Tuoi = Convert.ToInt16(Console.ReadLine());
     System.Console.Write("quequan = ");
    quequan = Console.ReadLine();
}
public void Display()
    {
    System.Console.WriteLine("{0} - {1} - {2}tuoi - {3}", masinhvien, Ten, Tuoi, quequan );
}
    }
}
