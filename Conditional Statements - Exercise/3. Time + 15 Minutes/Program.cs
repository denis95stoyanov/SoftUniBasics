// Въвеждане на час и минути от потребителя
int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

// Изчисляване на часа след 15 минути
int newHour = (hour + (minutes + 15) / 60) % 24;
int newMinutes = (minutes + 15) % 60;

// Отпечатване на резултата в желания формат
Console.WriteLine($"{newHour:D1}:{newMinutes:D2}");
