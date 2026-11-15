using System;
using System.Collections.Concurrent;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhap phan tu thu " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < A.Count; i++)
{
    System.Console.WriteLine("Phần tử thứ " + (i+1) +" sau khi bình phương là: " + (A[i] * A[i]));
}