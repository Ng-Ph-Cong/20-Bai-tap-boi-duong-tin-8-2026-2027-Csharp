using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

System.Console.Write("Nhập trung bình căn: ");
double tbc = double.Parse(Console.ReadLine());

List<double> A = new List<double>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    double can = Math.Sqrt(int.Parse(Console.ReadLine()));
    if (can > tbc)
    {
        A.Add(can);
    }
}

if (A.Count >= 1)
{
    System.Console.Write("Lớn hơn: ");
    foreach (double i in A)
    {
        System.Console.Write(i + " ");
    }
}
else
{
    System.Console.WriteLine("Không có");
}
