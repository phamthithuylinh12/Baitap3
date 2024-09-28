using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Bai 1:
         //    int num = 10;
         //    if (num % 3 == 0)
         //    {
         //        Console.WriteLine("so {0} chia het cho 3", num);
         //    }
         //    else
         //    {
         //        Console.WriteLine("so {0} khong chia het cho 3", num);
         //    }
         //    Console.ReadKey();
         //}
         //{//Bai 2:
         //    for (int i = 1; i <= 10; i++)
         //    {
         //        for (int j = 1; j <= 10; j++)
         //        {
         //            Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
         //        }
         //    }
         //    Console.ReadKey();
         //}
         //{//Bai3:
         //    int n = 9;
         //    long sum = 0;
         //    long giaithua = 1;
         //    for (int i = 1; i <= n; i++)
         //    {
         //       giaithua *= i;
         //        sum += giaithua;
         //    }
         //     Console.WriteLine("Tong giai thua tu 1 den " + n + " la: " + sum);
         //    Console.ReadKey();
         //}
         //{//Bai 5
         //    int month = 4;
         //    int year = 2024;
         //    if (month < 1 || month > 12)
         //    {
         //        Console.WriteLine("Thang {0} khong hop le", month);
         //        Console.ReadKey();
         //        return;
         //    }
         //    switch (month)
         //    {
         //        case 1:
         //        case 3:
         //        case 5:
         //        case 7:
         //        case 8:
         //        case 10:
         //        case 12:
         //            Console.WriteLine("Thang {0} co 31 ngay", month);
         //            break;
         //        case 4:
         //        case 6:
         //        case 9:
         //        case 11:
         //            Console.WriteLine("Thang {0} co 30 ngay", month);
         //            break;
         //        case 2:
         //            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
         //            {
         //                Console.WriteLine("Thang {0} co 29 ngay", month);
         //            }
         //            else
         //            {
         //                Console.WriteLine("Thang {0} co 28 ngay", month);
         //            }
         //            break;
         //            }
         //    Console.ReadKey();
         //}
         //{//Bai 6
         //    int n = 9;
         //    long sum = 0;
         //    for(int i = 1; i <= n; i++) 
         //    { 
         //        sum = (long)Math.Pow(i,i);
         //    }
         //    Console.WriteLine("Tong S la " + sum);
         //    Console.ReadKey();
         //}
         //{//bai 7
         //    int n = 29;
         //    long sum = 0;
         //    for (int i = 1; i <= n; i++)
         //    {
         //        if (i % 2 != 0)
         //        {
         //            sum += i;
         //        }
         //    }
         //    Console.WriteLine("Tong cac so le tu 1 den " + n + " la: " + sum);
         //    Console.ReadKey();
         //}
         //    {//Bai 8
         //        int n = 19;
         //        for (int i = 2; i <= n; i++)
         //        {
         //            if (snt(i))
         //            {
         //                Console.Write(i + " "); 
         //            }
         //        }
         //        Console.ReadKey();
         //    }
         //static bool snt(int number)
         //        {
         //            if (number < 2) return false;
         //            for (int i = 2; i <= Math.Sqrt(number); i++)
         //            {
         //                if (number % i == 0) return false; 
         //            }
         //            return true; 
         //        }
         //{///bai 9:tam giac thuong
         //    Console.Write("Nhap so hang: ");
         //    int n = int.Parse(Console.ReadLine());

            //    TamGiacThuong(n);
            //}

            //static void TamGiacThuong(int n)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.WriteLine(new string('*', i));
            //    }
            //    Console.ReadKey();
            //}

            //{//bai 9:tam giac deu
            //    Console.Write("Nhap so hang: ");
            //    int n = int.Parse(Console.ReadLine());

            //    TamGiacDeu(n);
            //}

            //static void TamGiacDeu(int n)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.Write(new string(' ', n - i)); 
            //        Console.WriteLine(new string('*', 2 * i - 1)); 
            //    }
            //    Console.ReadKey();
            //}
            //{//Bai9: tam giac xoay nguoc
            //    Console.Write("Nhap so hang: ");
            //    int n = int.Parse(Console.ReadLine());

            //    TamGiacXoayNguoc(n);
            //}

            //static void TamGiacXoayNguoc(int n)
            //{
            //    for (int i = n; i >= 1; i--)
            //    {
            //        Console.WriteLine(new string('*', i));
            //    }
            //    Console.ReadKey();
            //}
            //{//Bai 10
            //int a = 0, b = 1, c, n = 10;

            //Console.WriteLine("Day Fibonacci voi " + n + " phan tu la:");
            //Console.Write(a);
            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write(" " + b);
            //    c = a + b;
            //    a = b; 
            //    b = c; 
            //}
            //Console.WriteLine();
            //Console.ReadKey();
        }
    }
}

  

 