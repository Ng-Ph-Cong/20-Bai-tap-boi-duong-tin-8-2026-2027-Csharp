using System;

System.Console.Write("Nhap x = ");
int x = int.Parse(Console.ReadLine());

System.Console.Write("Nhap pt: ");
int pt = int.Parse(Console.ReadLine());

int kcnn = 999;
int gn = 0;
for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhap phan tu thu " + (i+1) + ": ");
    int so = int.Parse(Console.ReadLine());
    if (Math.Abs(so - x) < kcnn)
    {
        kcnn = Math.Abs(so - x);
        gn = so;
    }
}

System.Console.WriteLine("Gan nhat: " + gn);