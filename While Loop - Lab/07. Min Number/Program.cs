string input = Console.ReadLine();
int num = int.MaxValue;
while (input != "Stop")
{
    int newNumber = int.Parse(input);
    if (newNumber < num)
    { num = newNumber; }
    input = Console.ReadLine();
}
Console.WriteLine(num);