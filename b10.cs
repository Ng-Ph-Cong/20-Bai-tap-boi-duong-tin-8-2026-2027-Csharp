using System;

System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhap phan tu thu " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
}

int ln = A.Max();
int vtr = A.IndexOf(ln) + 1;

System.Console.WriteLine("Lon nhat " + ln + ", vi tri: " + vtr);