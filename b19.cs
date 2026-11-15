using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

System.Console.Write("Nhập a = ");
int a = int.Parse(Console.ReadLine());

System.Console.Write("Nhập b = ");
int b = int.Parse(Console.ReadLine());

int kq = 0;

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    double can = Math.Sqrt(int.Parse(Console.ReadLine()));
    if (can >= a && can <= b)
    {
        kq += 1;
    }
}

System.Console.WriteLine("Kết quả: " + kq);