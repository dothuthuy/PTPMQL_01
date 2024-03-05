namespace NEWAPP.Model
{
    public class Employee
    {
public int manhanvien { get; set; }
public string Ten { get ;set; }
public int Tuoi { get; set; }
public int Luong { get; set; }
public Employee()
{
    manhanvien = 21;
    Ten = "ho ten mac dinh";
    Tuoi = 22;
    Luong= 6000000;   
}
public void Display()
    {
    System.Console.WriteLine("{0} - {1} - {2}tuoi - {3}", masinhvien, Ten, Tuoi, quequan );
}
    }
}
