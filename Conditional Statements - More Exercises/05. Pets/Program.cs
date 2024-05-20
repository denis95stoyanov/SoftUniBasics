int days = int.Parse(Console.ReadLine());
int foodLeft = int.Parse(Console.ReadLine());
double foodPerDayForDog = double.Parse(Console.ReadLine());
double foodPerDayForCat = double.Parse(Console.ReadLine());
double foodPerDayForTurtle = double.Parse(Console.ReadLine()); //grams
foodPerDayForTurtle = foodPerDayForTurtle / 1000; // Храната за костенурката в кг.
double allFoodNeeded = (foodPerDayForCat + foodPerDayForDog + foodPerDayForTurtle) * days;
if (allFoodNeeded <= foodLeft)
    Console.WriteLine($"{Math.Floor(foodLeft - allFoodNeeded)} kilos of food left.");
else Console.WriteLine($"{Math.Ceiling(allFoodNeeded - foodLeft)} more kilos of food are needed.");
