string season = Console.ReadLine();
string typeOfGroop = Console.ReadLine();
int students = int.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double priceForNights = 0;
string sport = "";
double finalPrice = 0;
if (season == "Winter")
{
    if (typeOfGroop == "girls")
    {
        priceForNights += 9.6;
        sport = "Gymnastics";
    }
    else if (typeOfGroop == "boys")
    {
        priceForNights += 9.6;
        sport = "Judo";
    }
    else if (typeOfGroop == "mixed")
    {
        priceForNights += 10;
        sport = "Ski";
    }
}
else if (season == "Spring")
{
    switch (typeOfGroop)
    {
        case "boys":
            priceForNights += 7.2;
            sport = "Tennis"; break;
        case "girls":
            priceForNights += 7.2;
            sport = "Athletics"; break;
        case "mixed":
            priceForNights += 9.5;
            sport = "Cycling"; break;
        default: break;
    }
}
else if (season == "Summer")
{
    switch (typeOfGroop)
    {
        case "boys":
            priceForNights += 15;
            sport = "Football"; break;
        case "girls":
            priceForNights += 15;
            sport = "Volleyball"; break;
        case "mixed":
            priceForNights += 20;
            sport = "Swimming"; break;
        default: break;
    }
}
if (students >= 50)
{
    finalPrice += priceForNights * nights * students;
    finalPrice -= finalPrice * 0.5;
}
else if (students >= 20 && students < 50)
{
    finalPrice += priceForNights * nights * students;
    finalPrice -= finalPrice * 0.15;
}
else if (students >= 10 && students < 20)
{ 
    finalPrice += priceForNights * nights * students;
    finalPrice -= finalPrice * 0.05;
}
else finalPrice += priceForNights * nights * students;
Console.WriteLine($"{sport} {finalPrice:f2} lv.");
