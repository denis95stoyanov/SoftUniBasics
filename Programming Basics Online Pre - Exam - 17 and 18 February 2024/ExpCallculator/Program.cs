﻿int tourists = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
double pricePerTourist = 0;

if (season == "spring")
{
    if (tourists > 5)
    {
        pricePerTourist = 48;
    }
    else
    {
        pricePerTourist = 50;
    }
}
else if (season == "summer")
{
    if (tourists > 5)
    {
        pricePerTourist = 45;
    }
    else
    {
        pricePerTourist = 48.50;
    }
}
else if (season == "autumn")
{
    if (tourists > 5)
    {
        pricePerTourist = 49.50;
    }
    else
    {
        pricePerTourist = 60;
    }
}
else if (season == "winter")
{
    if (tourists > 5)
    {
        pricePerTourist = 85;
    }
    else
    {
        pricePerTourist = 86; 
    }
}
double finalPrice = pricePerTourist * tourists;
if (season == "summer")
{
    finalPrice -= finalPrice * 0.15;
}
else if (season == "winter")
{
    finalPrice += finalPrice * 0.08;
}
Console.WriteLine($"{finalPrice:F2} leva.");