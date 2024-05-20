double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string clas = "";
string typeOfCar = "";
double cabrioOrJeep = 0;
if (budget <= 100)
{
    clas = "Economy class";
    if (season == "Summer")
    {
        typeOfCar = "Cabrio";
        cabrioOrJeep += budget * 0.35;
    }
    else if (season == "Winter")
    {
        typeOfCar = "Jeep";
        cabrioOrJeep += budget * 0.65;
    }
}
else if (budget > 100 && budget <= 500)
{
    clas = "Compact class";
    if (season == "Summer")
    {
        typeOfCar = "Cabrio";
        cabrioOrJeep += budget * 0.45;
    }
    else if (season == "Winter")
    {
        typeOfCar = "Jeep";
        cabrioOrJeep += budget * 0.80;
    }
}
else
{
    clas = "Luxury class";
    typeOfCar = "Jeep";
    switch (season)
    {
        case "Summer":
        case "Winter":
            cabrioOrJeep += budget * 0.9; 
            break;
        default: break;
    }
}
Console.WriteLine($"{clas}");
Console.WriteLine($"{typeOfCar} - {cabrioOrJeep:f2}");
