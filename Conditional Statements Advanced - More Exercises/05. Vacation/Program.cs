double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string typeOfHouse = "";
string location = "";
double alaskaOrMorocco = 0;
if (budget <= 1000)
{
    typeOfHouse = "Camp";
    if (season == "Summer")
    {
        location = "Alaska";
        alaskaOrMorocco += budget * 0.65;
    }
    else if (season == "Winter")
    {
        location = "Morocco";
        alaskaOrMorocco += budget * 0.45;
    }
}
else if (budget > 1000 && budget <= 3000)
{
    typeOfHouse = "Hut";
    if (season == "Summer")
    {
        location = "Alaska";
        alaskaOrMorocco += budget * 0.8;
    }
    else if (season == "Winter")
    {
        location = "Morocco";
        alaskaOrMorocco += budget * 0.6;
    }
}
else
{
    typeOfHouse = "Hotel";
    if (season == "Summer")
    {
        location = "Alaska";
        alaskaOrMorocco += budget * 0.9;
    }
    else if (season == "Winter")
    {
        location = "Morocco";
        alaskaOrMorocco += budget * 0.9;
    }
}
Console.WriteLine($"{location} - {typeOfHouse} - {alaskaOrMorocco:f2}");
