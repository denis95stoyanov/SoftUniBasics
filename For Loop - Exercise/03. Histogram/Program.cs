int n = int.Parse(Console.ReadLine());
int P1 = 0;
int P2 = 0;
int P3 = 0;
int P4 = 0;
int P5 = 0;
for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200) P1++;
    else if (num < 400) P2++;
    else if (num < 600) P3++;
    else if (num < 800) P4++;
    else P5++;
}
Console.WriteLine($"{(double)P1 / n * 100:f2}%");
Console.WriteLine($"{(double)P2 / n * 100:f2}%");
Console.WriteLine($"{(double)P3 / n * 100:f2}%");
Console.WriteLine($"{(double)P4 / n * 100:f2}%");
Console.WriteLine($"{(double)P5 / n * 100:f2}%");
