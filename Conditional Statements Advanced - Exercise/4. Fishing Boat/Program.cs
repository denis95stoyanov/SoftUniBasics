int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int quantity =  int.Parse(Console.ReadLine());
double price = 0;
switch (season)
{
    case "Spring":
       price = 3000;
        break;
    case "Summer":
    case "Autumn":
        price = 4200;
    break;
    case "Winter":
        price = 2600;
        break;
    default: break;
}
if (quantity <= 6) price *= 0.9;
else if (quantity <= 11) price *= 0.85;
else price *= 0.75;
if (quantity % 2 == 0 && season != "Autumn") price *= 0.95;
if (price <= budget)
Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
else
Console.WriteLine($"Not enough money! You need {Math.Abs(budget - price):f2} leva.");