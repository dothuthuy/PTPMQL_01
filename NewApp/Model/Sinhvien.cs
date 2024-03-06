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
    try{
        Tuoi = Convert.ToInt16(Console.ReadLine());
    }catch(Exception e)
    {
        Tuoi = 0;
    }
    System.Console.Write("Sodienthoai = ");
    try{
        Sodienthoai = Convert.ToInt16(Console.ReadLine());
    }catch(Exception e)
    {
        Sodienthoai = 0;
    }
    }
}
}