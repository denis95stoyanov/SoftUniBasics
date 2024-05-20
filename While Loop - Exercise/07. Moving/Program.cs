int w = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int freeSpace = w * h * l;
string input = Console.ReadLine();
while (input != "Done")
{
    freeSpace -= int.Parse(input);
    if (freeSpace <= 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
        break; 
    }
    input = Console.ReadLine();
}
if (input == "Done")
{
    Console.WriteLine($"{freeSpace} Cubic meters left.");
}