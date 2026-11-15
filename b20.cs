using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

System.Console.Write("Nhập số pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhập phần tử thứ " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
}


System.Console.Write("Nhập x = ");
int x = int.Parse(Console.ReadLine());

int vtr = A.IndexOf(x) + 1;

if (vtr > 0)
{
    System.Console.WriteLine("Đã tìm thấy");
}
else
{
    int gn = 0;
    double kcnn = 999;
    for (int i = 0; i < pt; i++)
    {
        double candb = Math.Sqrt(A[i]);
        double kc = Math.Abs(candb - x);
        if (kc < kcnn)
        {
            kcnn = kc;
            gn = A[i];
        }
    }
    System.Console.WriteLine("Gần nhất theo căn: " + gn);
}