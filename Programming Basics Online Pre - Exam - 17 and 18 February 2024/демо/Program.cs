double tshirtPrice = double.Parse(Console.ReadLine());
double sum = double.Parse(Console.ReadLine());
double shortsPrice = tshirtPrice * 0.75;
double socksPrice = shortsPrice * 0.20;
double shoesPrice = (tshirtPrice + shortsPrice) * 2;
double totalPrice = tshirtPrice + shortsPrice + socksPrice + shoesPrice;
double discout = totalPrice * 0.15;
double discountedPrice = totalPrice - discout;
double moneyNeeded = sum - discountedPrice;

if (discountedPrice >= sum)
{
    Console.WriteLine("Yes, he will earn the world-cup replica ball!");
    Console.WriteLine($"His sum is {discountedPrice:f2} lv.");
}
else
{
    Console.WriteLine("No, he will not earn the world-cup replica ball.");
    Console.WriteLine($"He needs {Math.Abs(moneyNeeded):f2}lv.more.");
}
