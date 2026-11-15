using System;

System.Console.Write("Nhap so pt: ");
int pt = int.Parse(Console.ReadLine());

List<int> A = new List<int>();

for (int i = 0; i < pt; i++)
{
    System.Console.Write("Nhap pt thu " + (i+1) + ": ");
    A.Add(int.Parse(Console.ReadLine()));
}

double kcnn = 999;
int so1 = 0;
int so2 = 0;

if (pt > 2)
{
   for (int i = 0; i < pt - 1; i++)
    {
        for (int j = i+1; j < pt; j++)
        {
            double kc = Math.Abs(Math.Sqrt(A[i]) - Math.Sqrt(A[j]));
            if (kc < kcnn)
            {
                kcnn = kc;
                so1 = A[i];
                so2 = A[j];
            }
        }
    }
    System.Console.WriteLine("Khoang cach nho nhat: " + so1 + " va " + so2); 
}
else if (pt == 2)
{
    System.Console.WriteLine("Chi co mot cap");
}
else
{
    System.Console.WriteLine("Khong the so sanh");
}
