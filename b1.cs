using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();
List<double> B = new List<double>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
    B.Add(Math.Round(Math.Sqrt(A[i]) * 1000 ) / 1000);
}

for (int i = 0; i < B.Count; i++)
{
    System.Console.WriteLine("căn bậc hai của {0} là: {1}", A[i], B[i]);
}