int X = int.Parse(Console.ReadLine());
double Y = double.Parse(Console.ReadLine());
int Z = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());
double totalGrapes = X * Y;
double totalWine = (totalGrapes * 0.4) / 2.5;
double wineLeft = Math.Abs(totalWine - Z);
double wineForWorkers = wineLeft / workers;
if (totalWine >= Z)
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
    Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
}
else
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLeft)} liters wine needed.");
}
