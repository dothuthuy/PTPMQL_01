using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Person ps1 = new Person();
            Person ps2 = new Person();
        ps1.FullName = "Do Thu Thuy";
        ps1.Address =" Nam Dinh";
        ps1.Age = 18;
        ps1.Display();
        ps2.Display();    
        }
    }