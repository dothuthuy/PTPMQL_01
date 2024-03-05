using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Student ps = new Student();
            string str = "Do Thu Thuy";
            int b = 25;
            string str = "hoa hoc";
            Console.WriteLine("{0} - {1} - {2}",str , ps.GetYearOfBirth(b) ,str );
        }
        }
    
