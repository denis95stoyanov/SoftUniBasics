string fuel = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
if (fuel == "Diesel")
{
    if (quantity >= 25)
    {
        Console.WriteLine("You have enough diesel.");
    }
    else Console.WriteLine("Fill your tank with diesel!");
}
else if (fuel == "Gasoline")
{
    if (quantity >= 25)
    {
        Console.WriteLine("You have enough gasoline.");
    }
    else Console.WriteLine("Fill your tank with gasoline!");
}
else if(fuel == "Gas")
{
    if (quantity >= 25)
    {
        Console.WriteLine("You have enough gas.");
    }
    else Console.WriteLine("Fill your tank with gas!");
}
else Console.WriteLine("Invalid fuel!");