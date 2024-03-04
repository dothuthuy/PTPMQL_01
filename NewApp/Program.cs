using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    class ToanTu
{
    static void Main()
    {
        Console.WriteLine(" a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" b = ");
        int  b = Convert.ToInt32(Console.ReadLine());

        int tong = a + b;
        int hieu = a -b;
        int tich = a * b;

        Console.WriteLine($"Tong {a} + {b} = {tong}");
        Console.WriteLine($"Hieu {a} - {b} = {hieu}");
        Console.WriteLine($"Tich {a} * {b} = {tich}");

        if (b != 0)
        {
            float thuong = (float)a /b;
            int du =a % b;
            Console.WriteLine($"Thuong {a} / {b} = {thuong}");
            Console.WriteLine($" Phan du {a} % {b} = {du}");
        }else
        {
        Console.WriteLine("Khong thuc hien duoc phep chia va phep lay du");
    }
}
}
}