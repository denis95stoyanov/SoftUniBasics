int targetForTheDay = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
double profit = 0;
while (command != "closed")
{
    if (command == "haircut")
    {
        string typeOfHaircut = Console.ReadLine();
        if (typeOfHaircut == "mens")
            profit += 15;
        else if (typeOfHaircut == "ladies")
            profit += 20;
        else if (typeOfHaircut == "kids")
            profit += 10;
        else return;
    }
    else if (command == "color")
    { 
        string color = Console.ReadLine();
        if (color == "touch up")
            profit += 20;
        else if (color == "full color")
            profit += 30;
        else return;
    }
    else return;
    if (profit >= targetForTheDay) break;
    command = Console.ReadLine();
}
if (profit >= targetForTheDay)
    Console.WriteLine("You have reached your target for the day!");
else Console.WriteLine($"Target not reached! You need {targetForTheDay - profit}lv. more.");
Console.WriteLine($"Earned money: {profit}lv.");