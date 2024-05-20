double buget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int people = int.Parse(Console.ReadLine());
double VIP = 499.99;
double normal = 249.99;
double transport = 0;
double moneyNeeded = 0;
if (people >= 1 && people <= 4) transport += buget * 0.75;
else if (people >= 5 && people <= 9) transport += buget * 0.6;
else if (people >= 10 && people <= 24) transport += buget * 0.5;
else if (people >= 25 && people <= 49) transport += buget * 0.4;
else transport += buget * 0.25;
if (category == "VIP")
{
    moneyNeeded = people * VIP + transport;
    if (moneyNeeded <= buget)
        Console.WriteLine($"Yes! You have {buget - moneyNeeded:f2} leva left.");
    else Console.WriteLine($"Not enough money! You need {moneyNeeded - buget:f2} leva.");
}
else if (category == "Normal")
{
    moneyNeeded = people * normal + transport;
    if (moneyNeeded <= buget)
        Console.WriteLine($"Yes! You have {buget - moneyNeeded:f2} leva left.");
    else Console.WriteLine($"Not enough money! You need {moneyNeeded - buget:f2} leva.");
}
