using System.ComponentModel.Design.Serialization;
using System.Reflection;
using NEWAPP.Model;

    public class Program
    {
        private static void Main(string[] args)
        {
            Sinhvien ps1 = new Sinhvien ();
            Sinhvien ps2 = new Sinhvien ();
            ps1.Hoten = "Do Thu Thuy";
            ps1.Diachi = "Nam Dinh";
            ps1.Tuoi = 22;
            ps1.Sodienthoai = 123456768;
            ps1.Display();
            ps2.Hoten = "Do Huyen Trang";
            ps2.Diachi= "Ha Noi";
            ps2.Tuoi= 21;
            ps2.Sodienthoai =44565788;
            ps2.Display();
        }
    }