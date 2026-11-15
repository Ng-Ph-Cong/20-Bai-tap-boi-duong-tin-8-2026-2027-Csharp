using System;
using System.Numerics;
using System.Text;
using System.Linq;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());

List<double> A = new List<double>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhap phan tu thu " + (i+1) + ": ");
    A.Add(Math.Round(Math.Sqrt(int.Parse(Console.ReadLine())) * 1000) /1000);
}

System.Console.Write("Nhap x = ");
int x = int.Parse(Console.ReadLine());

int kq = A.Count(Z => Z > x);
System.Console.WriteLine(kq);