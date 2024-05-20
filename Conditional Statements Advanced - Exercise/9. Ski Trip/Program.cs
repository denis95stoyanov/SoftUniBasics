int days = int.Parse(Console.ReadLine());
string roomStyle = Console.ReadLine();
string roomRate = Console.ReadLine();
int nights = days - 1;

if (roomStyle  == "room for one person")
{
    double price = 18.00;
    if (roomRate == "positive")
    {
        double finalPrice = price * nights;
        finalPrice = finalPrice + finalPrice * 0.25;
        Console.WriteLine($"{finalPrice:f2}");
    }
    else if (roomStyle == "negative")
    {
        double finalPrice = price * nights;
        finalPrice = finalPrice - finalPrice * 0.1;
        Console.WriteLine($"{finalPrice:f2}");
    }
}
else if (roomStyle == "apartment")
{
    double price = 25.00;
    if(roomRate == "positive")
    {
        if (days < 10)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.3;
            finalPrice = finalPrice + finalPrice * 0.25;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else if (days >= 10 && days <= 15)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.35;
            finalPrice = finalPrice + finalPrice * 0.25;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.5;
            finalPrice = finalPrice + finalPrice * 0.25;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
    else if (roomRate == "negative")
    {
        if (days < 10)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.3;
            finalPrice = finalPrice - finalPrice * 0.1;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else if (days >= 10 && days <= 15)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.35;
            finalPrice = finalPrice - finalPrice * 0.1;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.5;
            finalPrice = finalPrice - finalPrice * 0.1;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
else if (roomStyle == "president apartment")
{
    double price = 35.00;
    if (roomRate == "positive")
    {
        if (days < 10)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.1;
            finalPrice = finalPrice + finalPrice * 0.25;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else if (days >= 10 && days <= 15)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.15;
            finalPrice = finalPrice + finalPrice * 0.25;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.2;
            finalPrice = finalPrice + finalPrice * 0.25;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
    else if (roomRate == "negative")
    {
        if (days < 10)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.1;
            finalPrice = finalPrice - finalPrice * 0.1;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else if (days >= 10 && days <= 15)
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.15;
            finalPrice = finalPrice - finalPrice * 0.1;
            Console.WriteLine($"{finalPrice:f2}");
        }
        else
        {
            double finalPrice = price * nights;
            finalPrice = finalPrice - finalPrice * 0.2;
            finalPrice = finalPrice - finalPrice * 0.1;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}