int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());
double catFPrice = 4 * catFood;
double dogFPrice = 2.50 * dogFood;
double endPrice = catFPrice + dogFPrice;
Console.WriteLine($" {endPrice} lv.");
