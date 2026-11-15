using System;

System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();
for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhap phan tu thu " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
}

if (A.Count > 1)
{
    System.Console.Write("Nhap tbc = ");
    double tbc = double.Parse(Console.ReadLine());

    double kcnn = 999;
    int so = 0;

    for (int i = 0; i < pt; i++)
    {
        double can = Math.Round(Math.Sqrt(A[i]) * 1000 ) / 1000;
        double kc = Math.Abs(can - tbc);
        if (kc < kcnn)
        {
            kcnn = kc;
            so = A[i];
        }
    }

    System.Console.WriteLine("Gan nhat: " + so);
}
else
{
    System.Console.WriteLine("Chinh no");
}