int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

for (int i = 2; i <= x; i += 2)
{
    for (int j = 2; j <= y; j++)
    {
        for (int k = 2; k <= z; k += 2)
        {
            if (j == 2 || j == 3 || j == 5 || j == 7)
                Console.WriteLine($"{i} {j} {k}");
        }
    }
}
