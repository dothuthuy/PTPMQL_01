using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Employee ps = new Employee();
            int a = 21;
            string str = "Do Thu Thuy";
            int b = 25;
            int c =26;
            Console.WriteLine("{0} - {1} - {2} - {3}", a ,str , ps.GetYearOfBirth(b) ,c  );
        }
        }
    
