namespace NEWAPP.Model
{
    public class Employee
    {
public string manhanvien { get; set; }
public string Ten { get ;set; }
public int Tuoi { get; set; }
public int Luong { get; set; }
public void EnterData()
{
    System.Console.Write("manhanvien = ");
    manhanvien = Console.ReadLine();
    System.Console.Write("Ten = " );
    Ten = Console.ReadLine();
     System.Console.Write("Tuoi = ");
    Tuoi = Convert.ToInt16(Console.ReadLine());
     System.Console.Write("Luong = ");
    Luong = Convert.ToInt16(Console.ReadLine());
}
public void Display()
    {
    System.Console.WriteLine("{0} - {1} - {2}tuoi - {3}", manhanvien, Ten, Tuoi, Luong);
}
    }
}
