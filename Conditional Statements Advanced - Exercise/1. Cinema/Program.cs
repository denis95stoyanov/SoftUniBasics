string projection = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int  column = int.Parse(Console.ReadLine());
double income = 0;
double price = 0;
if  (projection == "Premiere")
{
    price = 12.00;
    income = row * column * price;
    Console.WriteLine($"{income:f2} leva");
}
else if (projection == "Normal")
{
    price = 7.50;
    income = row * column * price;
    Console.WriteLine($"{income:f2} leva");
}
else if (projection == "Discount")
{
    price = 5.00;
    income = row * column * price;
    Console.WriteLine($"{income:f2} leva");
}