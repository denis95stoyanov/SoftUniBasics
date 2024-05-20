string bestPlayer = "";
int maxGoals = 0;
string playerName = Console.ReadLine();
while (playerName != "END")
{
    int goals = int.Parse(Console.ReadLine());
    if (goals > maxGoals)
    {
        bestPlayer = playerName;
        maxGoals = goals;
    }
    if (goals >= 10)
    {
        break;
    }

    playerName = Console.ReadLine();
}

Console.WriteLine($"{bestPlayer} is the best player!");
if (maxGoals >= 3)
    Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
else
    Console.WriteLine($"He has scored {maxGoals} goals.");
