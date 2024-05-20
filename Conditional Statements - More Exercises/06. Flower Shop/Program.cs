int magnolias = int.Parse(Console.ReadLine());
int zumbuls = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int cactus = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());
double magnoliaPrice = magnolias * 3.25;
double rosesPrice = roses * 3.5;
double cactusPrice = cactus * 8;
double zumbulPrice = zumbuls * 4;
double tax = (magnoliaPrice + rosesPrice + cactusPrice + zumbulPrice) * 0.05;
double profit = (magnoliaPrice + rosesPrice + cactusPrice + zumbulPrice) - tax;

if (profit >= giftPrice)
    Console.WriteLine($"She is left with {Math.Floor(profit - giftPrice)} leva.");
else
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - profit)} leva.");
