using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập số phần tử: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();
List<int> Kq = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
    double can = Math.Sqrt(A[i]);
    if (can * can == A[i])
    {
        Kq.Add(A[i]);
    }
}

for (int i = 0; i < Kq.Count; i++)
{
    System.Console.Write(Kq[i] + " ");
}