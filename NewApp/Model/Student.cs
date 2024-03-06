namespace NEWAPP.Model
{
    public class Student
    {
public string Hoten { get ;set; }
public int Tuoi { get; set; }
public string monhoc { get; set; }
 public void EnterData()
{
    System.Console.Write("Hoten = " );
    Hoten = Console.ReadLine();
    System.Console.Write("Tuoi = ");
    try{
        Tuoi = Convert.ToInt16(Console.ReadLine());
    }catch(Exception e)
    {
        Tuoi = 0;
    }
    System.Console.Write("monhoc = " );
    monhoc = Console.ReadLine();
   
}
}
}


