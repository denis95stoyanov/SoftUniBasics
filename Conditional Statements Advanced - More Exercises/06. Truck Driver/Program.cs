string season = Console.ReadLine();
double kilometers = double.Parse(Console.ReadLine());
double payment = 0;
if (kilometers <= 5000)
{
    if (season == "Spring" || season == "Autumn") payment += kilometers * 0.75;
    else if (season == "Summer") payment += kilometers * 0.9;
    else if (season == "Winter") payment += kilometers * 1.05;
}
else if (kilometers > 5000 && kilometers <= 10000)
{
    if (season == "Spring" || season == "Autumn") payment += kilometers * 0.95;
    else if (season == "Summer") payment += kilometers * 1.1;
    else if (season == "Winter") payment += kilometers * 1.25;
}
else if (kilometers > 10000 && kilometers <= 20000)
{
    switch (season)
    {
        case "Spring":
        case "Summer":
        case "Autumn":
        case "Winter":
            payment += kilometers * 1.45; break;
        default: break;
    }    
}
double paymentAfterTax = payment * 4 - (payment * 4) * 0.1;
Console.WriteLine($"{paymentAfterTax:f2}");