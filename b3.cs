using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());
double tong = 0;

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    tong += Math.Round(Math.Sqrt(int.Parse(Console.ReadLine())) * 1000) /1000;
}

System.Console.WriteLine("Tổng = " + tong);