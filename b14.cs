using System;
using System.Net;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

List<double> A = new List<double>();

for (double i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    A.Add( Math.Floor( Math.Sqrt(double.Parse(Console.ReadLine()))));
}

foreach (double i in A)
{
    System.Console.Write(i + " ");
}