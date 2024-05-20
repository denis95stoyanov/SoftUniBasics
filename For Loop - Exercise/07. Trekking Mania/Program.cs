int groups = int.Parse(Console.ReadLine());
int allPeople = 0;
double musala = 0;
double monblan = 0;
double kilimandjaro = 0;
double k2 = 0;
double everest = 0;
for (int people = 1; people <= groups; people++)
{
    int groupPeople = int.Parse(Console.ReadLine());
    allPeople += groupPeople;
    if (groupPeople <= 5) musala += groupPeople;
    else if (groupPeople <= 12) monblan += groupPeople;
    else if (groupPeople <= 25) kilimandjaro += groupPeople;
    else if (groupPeople <= 40) k2 += groupPeople;
    else everest += groupPeople;
}
Console.WriteLine($"{musala / allPeople * 100:f2}%");
Console.WriteLine($"{monblan / allPeople * 100:f2}%");
Console.WriteLine($"{kilimandjaro / allPeople *100:f2}%");
Console.WriteLine($"{k2 / allPeople * 100:f2}%");
Console.WriteLine($"{everest / allPeople * 100:f2}%");