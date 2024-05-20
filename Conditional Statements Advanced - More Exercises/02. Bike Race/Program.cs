int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string trace = Console.ReadLine();
double juniorPrice = 0;
double seniorPrice = 0;
double disscount = 0;
if (trace == "trail")
{
    juniorPrice += 5.5;
    seniorPrice += 7;
}
else if(trace == "cross-country")
{
    juniorPrice += 8;
    seniorPrice += 9.5;
    if (juniors + seniors >= 50)
    {
        juniorPrice = juniorPrice - juniorPrice * 0.25;
        seniorPrice = seniorPrice - seniorPrice * 0.25;
    }
}
else if (trace == "downhill")
{
    juniorPrice += 12.25;
    seniorPrice += 13.75;
}
else if (trace == "road")
{
    juniorPrice += 20;
    seniorPrice += 21.5;
}    
double donation = juniorPrice * juniors + seniorPrice * seniors;
double tax = donation * 0.05;
Console.WriteLine($"{donation - tax:f2}");
