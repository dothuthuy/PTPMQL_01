namespace NEWAPP.Model
{
    public class Employee
    {
public int manhanvien { get; set; }
public string Ten { get ;set; }
public int Tuoi { get; set; }
public int Luong { get; set; }
public void Display2( int manhanvien, string Ten, int Tuoi, int Luong)
{
    System.Console.WriteLine("{0} - {1} - {2} tuoi - {3}", manhanvien , Ten, Tuoi, Luong);
    }
    }
}
