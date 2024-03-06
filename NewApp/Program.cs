using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Sinhvien ps = new Sinhvien();
        ps.EnterData();
        ps.Display();
        }
    }
    
