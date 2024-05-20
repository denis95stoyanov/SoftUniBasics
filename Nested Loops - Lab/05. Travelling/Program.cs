string destination = Console.ReadLine();
while (destination != "End")
{

    double price = double.Parse(Console.ReadLine());
    double savings = 0;
    while (savings < price)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        savings += currentMoney;
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}