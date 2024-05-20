// Вход
double w = double.Parse(Console.ReadLine()); // дължина в метри
double h = double.Parse(Console.ReadLine()); // ширина в метри

// Изчисления
double totalWidhtInCm = w * 100; // превръщаме дължината в сантиметри
double totalLenghtInCm = h * 100; // превръщаме широчината в сантиметри

double width = 120;
double lengt = 70;
double hall = 100;
int takenDesks = 3;
// Изчисляваме броя на работните места във всяка част на залата
double leftPartDesks = Math.Floor(totalWidhtInCm / width);
double rightPartDesks = Math.Floor((totalLenghtInCm - hall) / lengt);

// Общ брой работни места
double allDesks = leftPartDesks * rightPartDesks - takenDesks;

// Изход
Console.WriteLine(allDesks);
