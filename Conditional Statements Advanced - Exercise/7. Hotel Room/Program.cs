string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
double discountStudio = 1;
double discountApartment = 1;
if (month == "May" ||  month == "October")
{
    double priceStudio = 0;
    double studio = 50;
    if (nights > 7 && nights < 14) 
    {
        discountStudio *= 0.05;
        priceStudio = (studio - studio * discountStudio) * nights;
    }
    else if (nights > 14)
    {
        discountStudio *= 0.3;
        priceStudio = (studio - studio * discountStudio) * nights;
    }
    else priceStudio = studio * nights;
    double priceApartment = 0;
    double apartment = 65;
    if (nights > 14)
    {
        discountApartment *= 0.1;
        priceApartment = (apartment - apartment * discountApartment) * nights;
    }
    else priceApartment = apartment * nights;
    Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
}
else if (month == "June" || month == "September")
{
    double priceStudio = 0;
    double studio = 75.2;
    if (nights > 14)
    {
        discountStudio *= 0.2;
        priceStudio = (studio - studio * discountStudio) * nights;
    }
    else priceStudio = studio * nights;
    double priceApartment = 0;
    double apartment = 68.7;
    if (nights > 14)
    {
        discountApartment *= 0.1;
        priceApartment = (apartment - apartment * discountApartment) * nights;
    }
    else priceApartment = apartment * nights;
    Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
}
else if(month =="July" ||  month =="August")
{
    double priceStudio = 0;
    double studio = 76;
    priceStudio = studio * nights;
    double priceApartment = 0;
    double apartment = 77;
    if (nights > 14)
    {
        discountApartment *= 0.1;
        priceApartment = (apartment - apartment * discountApartment) * nights;
    }
    else priceApartment = apartment * nights;
    Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
}