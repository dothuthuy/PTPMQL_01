using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Student ps1 = new Student ();
            Student ps2 = new Student ();
            ps1.Ten = "Do Thu Thuy";
            ps1.Tuoi = 22;
            ps1.monhoc = "Hoa hoc";
            ps1.Display();
            ps2.Ten = "Do Huyen Trang";
            ps2.Tuoi= 21;
            ps2.monhoc= "Van hoc";
            ps2.Display();
        }
    }