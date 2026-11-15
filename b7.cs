using System;

System.Console.Write("Nhap pt: ");
int pt = int.Parse(Console.ReadLine());

List<double> A = new List<double>();

for (int i = 0; i< pt; i++)
{
    System.Console.Write("Nhap phan tu thu " + (i+1) + ": ");
    A.Add(Math.Sqrt(Double.Parse(Console.ReadLine())));
}

System.Console.Write("Nhap x = ");
double x = double.Parse(Console.ReadLine());

int vtri = A.IndexOf(x) + 1;

if (vtri > 0)
{
    System.Console.WriteLine("Tim thay tai vi tri: " + vtri);
}
else
{
    System.Console.WriteLine("Ko tim thay");
}