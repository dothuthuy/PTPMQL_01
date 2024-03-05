using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Employee ps1 = new Employee();
            Employee ps2 = new Employee();
            ps1.manhanvien = 26;
            ps1.Ten = "Do Thu Thuy";
            ps1.Tuoi = 28;
            ps1.Luong = 6000000;
            ps1.Display();
            ps2.Display();
        }
        }
    }