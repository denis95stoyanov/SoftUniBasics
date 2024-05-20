string fuelType = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
string disscountCard = Console.ReadLine();
double fuelPrice = 0;
double finalPrice = 0;
if (fuelType == "Gasoline")
{
    fuelPrice = 2.22;
    if (disscountCard == "Yes")
    {
        fuelPrice -= 0.18;
        finalPrice = fuelPrice * quantity;
    }
    else if (disscountCard == "No")
    {
        finalPrice = fuelPrice * quantity;
    }
    if (quantity >= 20 && quantity <= 25)
    {
        finalPrice = finalPrice - finalPrice * 0.08;
    }
    else if (quantity > 25)
    { finalPrice = finalPrice - finalPrice * 0.1; }
    Console.WriteLine($"{finalPrice:f2} lv.");
}
else if (fuelType == "Diesel")
{
    fuelPrice = 2.33;
    if (disscountCard == "Yes")
    {
        fuelPrice -= 0.12;
        finalPrice = fuelPrice * quantity;
    }
    else if (disscountCard == "No")
    {
        finalPrice = fuelPrice * quantity;
    }
    if (quantity >= 20 && quantity <= 25)
    {
        finalPrice = finalPrice - finalPrice * 0.08;
    }
    else if (quantity > 25)
    { finalPrice = finalPrice - finalPrice * 0.1; }
    Console.WriteLine($"{finalPrice:f2} lv.");
}
else if (fuelType == "Gas")
{
    fuelPrice = 0.93;
    if (disscountCard == "Yes")
    {
        fuelPrice -= 0.08;
        finalPrice = fuelPrice * quantity;
    }
    else if (disscountCard == "No")
    {
        finalPrice = fuelPrice * quantity;
    }
    if (quantity >= 20 && quantity <= 25)
    {
        finalPrice = finalPrice - finalPrice * 0.08;
    }
    else if (quantity > 25)
    { finalPrice = finalPrice - finalPrice * 0.1; }
    Console.WriteLine($"{finalPrice:f2} lv.");
}

