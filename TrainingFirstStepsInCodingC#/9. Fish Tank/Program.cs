//1. Дължина в см – цяло число в интервала [10 … 500]
double lenght = double.Parse(Console.ReadLine());
//2.Широчина в см – цяло число в интервала [10 … 300]
double widht = double.Parse(Console.ReadLine());
//3.Височина в см – цяло число в интервала [10… 200]
double height = double.Parse(Console.ReadLine());
//4.Процент – реално число в интервала [0.000 … 100.000]
double percent = double.Parse(Console.ReadLine());
double volumeInSm = lenght * widht * height;
double volumeInLiters = volumeInSm * 0.001;
double volumePercent = percent / 100;
double liters = volumeInLiters * (1 - volumePercent);
//Да се отпечата на конзолата едно число:литрите вода, които ще събира аквариума.
Console.WriteLine(liters);