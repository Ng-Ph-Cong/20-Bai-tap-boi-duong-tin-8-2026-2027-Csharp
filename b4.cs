using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();

for (int i = 0; i < pt; i++)
{
    A.Add(int.Parse(Console.ReadLine()));
}

int ln = A.Max();
int vtr = A.IndexOf(ln) + 1;
System.Console.WriteLine("Lớn nhất " + ln + " Vị trí: " + vtr);
A.Max();