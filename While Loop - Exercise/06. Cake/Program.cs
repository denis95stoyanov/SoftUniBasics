int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int cakeSize = width * height;
string input = Console.ReadLine();
while (input != "STOP")
{
    cakeSize -= int.Parse(input);
    if (cakeSize <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
        break;
    }
    input = Console.ReadLine();
}
if ( input == "STOP")
{
    Console.WriteLine($"{cakeSize} pieces are left.");
}
