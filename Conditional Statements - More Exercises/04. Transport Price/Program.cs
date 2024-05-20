int n = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();
double taxiDay = 0.7 ;
double taxiNight = 0.7;
double bus = 0.09;
double train = 0.06;
if (dayTime == "day")
{
    if (n < 20)
    {
        taxiDay += 0.79 * n;
        Console.WriteLine($"{taxiDay:f2}");
    }
    else if (n >= 20 && n < 100)
    {
        bus = bus * n;
        Console.WriteLine($"{bus:f2}");
    }
    else
    {
        train = train * n;
        Console.WriteLine($"{train:f2}");
    }
}
else if (dayTime == "night")
{
    if (n < 20)
    {
        taxiNight += 0.9 * n;
        Console.WriteLine($"{taxiNight:f2}");
    }
    else if (n >= 20 && n < 100)
    {
        bus = bus * n;
        Console.WriteLine($"{bus:f2}");
    }
    else
    {
        train = train * n;
        Console.WriteLine($"{train:f2}");
    }
}
