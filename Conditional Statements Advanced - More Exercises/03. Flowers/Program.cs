int chrysanthemums = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int tulips = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char YorN = char.Parse(Console.ReadLine());
double chrysanthemumsPrice = 0;
double rosesPrice = 0;
double tulipsPrice = 0;
switch(season)
{
    case "Spring":
    case "Summer":
        chrysanthemumsPrice += 2;
        rosesPrice += 4.1;
        tulipsPrice += 2.5;
        break;
    case "Autumn":
    case "Winter":
        chrysanthemumsPrice += 3.75;
        rosesPrice += 4.5;
        tulipsPrice += 4.15;
        break;
    default: break;
}
double buketPrice = chrysanthemums * chrysanthemumsPrice + roses * rosesPrice + tulips * tulipsPrice;
if (YorN == 'Y') buketPrice += buketPrice * 0.15;
if (tulips > 7 && season == "Spring") buketPrice -= buketPrice * 0.05;
else if (roses >= 10 && season == "Winter") buketPrice -= buketPrice * 0.1;
if (chrysanthemums + roses + tulips > 20) buketPrice -= buketPrice * 0.2;
double finalPrice = buketPrice + 2;
Console.WriteLine($"{finalPrice:f2}");
