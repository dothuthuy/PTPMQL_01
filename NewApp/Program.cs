using System.ComponentModel.Design.Serialization;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Employee ps1 = new Employee ();
            Employee ps2 = new Employee ();
            ps1.manhanvien = 21;
            ps1.Ten = " Nguyen Van A";
            ps1.Tuoi = 18;
            ps1.Luong = 3000000; 
            ps1.Display();
            ps2.manhanvien = 22;
            ps2.Ten= "Do Thu Thuy";
            ps2.Tuoi= 22;
            ps2.Luong = 6000000;
            ps2.Display();
        }
    }