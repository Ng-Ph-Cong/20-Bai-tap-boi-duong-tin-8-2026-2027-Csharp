using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập x = ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    int so = int.Parse(Console.ReadLine());
    if ( so > x)
    {
       A.Add(so);
    }
}

System.Console.Write("[");
for (int i = 0; i < A.Count; i++)
{
    if (i != A.Count -1)
    {
        System.Console.Write(A[i] + ", ");
    }
    else
    {
        System.Console.Write(A[i] + "]");
    }

}