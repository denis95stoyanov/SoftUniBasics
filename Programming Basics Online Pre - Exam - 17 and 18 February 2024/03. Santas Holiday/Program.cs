int days = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string evaluation = Console.ReadLine();
int nights = days - 1;
double finalPrice = 0;
switch (typeOfRoom)
{
    case "room for one person":
        finalPrice = nights * 18.00;
        if (evaluation == "positive")
            finalPrice += finalPrice * 0.25;
        else if (evaluation == "negative")
            finalPrice -= finalPrice * 0.1;
        break;
    case "apartment":
        if (days < 10)
            finalPrice = (nights * 25.00) * 0.7;
        else if (days >= 10 && days <= 15)
            finalPrice = (nights * 25.00) * 0.65;
        else finalPrice = (nights * 25.00) * 0.5;
        if (evaluation == "positive")
            finalPrice += finalPrice * 0.25;
        else if (evaluation == "negative")
            finalPrice -= finalPrice * 0.1;
        break;
    case "president apartment":
        if (days < 10)
            finalPrice = (nights * 35.00) * 0.9;
        else if (days >= 10 && days <= 15)
            finalPrice = (nights * 35.00) * 0.85;
        else finalPrice = (nights * 35.00) * 0.8;
        if (evaluation == "positive")
            finalPrice += finalPrice * 0.25;
        else if (evaluation == "negative")
            finalPrice -= finalPrice * 0.1;
        break;
        default: break;
}
Console.WriteLine($"{finalPrice:f2}");
