namespace NEWAPP.Model
{
    public class Student
    {
public string Hoten { get ;set; }
public int Tuoi { get; set; }
public string monhoc { get; set; }
public void Display2( string Hoten, int Tuoi, string monhoc)
{
    System.Console.WriteLine("{0} - {1} tuoi - {2}", Hoten, Tuoi, monhoc);
    }
}
}


