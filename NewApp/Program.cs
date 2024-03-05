using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Person ps = new Person();
            string str = "Do Thu Thuy";
            int a = 22;
            Console.WriteLine("{0} sinh nam {1}", str , ps.GetYearOfBirth(a));
        }
    }