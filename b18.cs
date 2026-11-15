using System;
using System.Text;
using System.Collections.Generic;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();
List<int> DX = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " +(i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));

    double canDB = Math.Sqrt(A[i]);
    int canLo = (int)canDB;
    if (canLo * canLo == A[i])
    {
        int n = canLo;
        int dx = 0;
        while (n > 0)
        {
            dx = dx * 10 + n % 10;
            n /= 10;
        }

        if (dx == canLo)
        {
            DX.Add(canLo);
        } 
    }
}

if (DX.Count >= 1)
{
    System.Console.Write("Đối xứng: ");
    for (int i = 0; i < DX.Count; i++)
    {
        System.Console.Write(DX[i] + " ");
    }
}
else
{
    System.Console.WriteLine("Không có");
}
