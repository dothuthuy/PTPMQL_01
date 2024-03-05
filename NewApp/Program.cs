using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Student ps1 = new Student();
            Student ps2 = new Student();
            ps1.Hoten = "Do Thu Thuy";
            ps1.Tuoi = 21;
            ps1.monhoc = "Hoa hoc";
            ps1.Display();
            ps2.Display();
        }
        }
    }