namespace NEWAPP.Model
{
    public class Sinhvien
    {
public string Hoten { get ;set; }
public string Diachi { get; set; }
public int Tuoi { get; set; }
public int Sodienthoai { get; set; }
public void EnterData()
{
    System.Console.Write("Hoten = " );
    Hoten = Console.ReadLine();
    System.Console.Write("Diachi = " );
    Diachi = Console.ReadLine();
    System.Console.Write("Tuoi = ");
    Tuoi = Convert.ToInt16(Console.ReadLine());
    System.Console.Write("Sodienthoai = ");
    Sodienthoai= Convert.ToInt16(Console.ReadLine());
    
}
public void Display()
    {
    System.Console.WriteLine("{0} - {1} - {2}tuoi - {3}"Hoten, Diachi, Tuoi, Sodienthoai);
}
    }
}
