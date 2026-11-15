using System;
using System.Text;
using System.Collections.Generic;

Console.OutputEncoding = Encoding.UTF8;
System.Console.Write("Nhập pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();
for (int i = 0; i < pt; i++)
{
    A.Add(int.Parse(Console.ReadLine()));
}
int x = int.Parse(Console.ReadLine());
int vtri = A.IndexOf(x) +1;

if (vtri > 0)
{
    System.Console.WriteLine("Vi trí: " + vtri);
}
else
{
    System.Console.WriteLine("Không tìm thấy");
}