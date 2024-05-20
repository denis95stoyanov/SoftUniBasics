string flower = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double finalPrice = 0;
double priceOfFlower = 0;

  switch (flower)
{
    case "Roses":
        priceOfFlower = 5;
        finalPrice = priceOfFlower * quantity;
        if (quantity > 80)
            finalPrice *= 0.9;
        break;
    case "Dahlias":
        priceOfFlower = 3.8;
        finalPrice = priceOfFlower * quantity;
        if (quantity > 90)
            finalPrice *= 0.85;
        break;
    case "Tulips":
        priceOfFlower = 2.8;
        finalPrice = priceOfFlower * quantity;
        if (quantity > 80)
            finalPrice *= 0.85;
        break;
    case "Narcissus":
        priceOfFlower = 3;
        finalPrice = priceOfFlower * quantity;
        if (quantity < 120)
            finalPrice = finalPrice + finalPrice * 0.15;
        break;
    case "Gladiolus":
        priceOfFlower = 2.5;
        finalPrice = priceOfFlower * quantity;
        if (quantity < 80)
            finalPrice = finalPrice + finalPrice * 0.2;
        break;
    default: break;
}
if (finalPrice <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - finalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {Math.Abs(budget - finalPrice):f2} leva more.");
}
