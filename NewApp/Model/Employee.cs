using Your_Namespace;

namespace NEWAPP.Model
{
    public class Employee
    {
public int manhanvien { get; set;}
public string Ten { get; set;}
public int Tuoi { get; set;}
public int Luong { get; set;}
public void EnterData()
{
    System.Console.Write("manhanvien =");
    try{
        manhanvien = Convert.ToInt16(Console.ReadLine());
    }catch(Exception e)
    {
        manhanvien = 0;
    }
    
    System.Console.Write("Ten =");
    Ten = Console.Readline();
    System.Console.Write("Tuoi =");
    try{
        Tuoi = Convert.ToInt16(Console.ReadLine());
    }catch(Exception e)
    {
        Tuoi = 0;
    }
    System.Console.Write("Luong =");
    try{
        Luong = Convert.ToInt16(Console.ReadLine());
    }catch(Exception e)
    {
        Luong = 0;
    }
}
    }
}

