double budget = double.Parse(Console.ReadLine());
int videoCard = int.Parse(Console.ReadLine());
int processor =  int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());
double videoCardPrice = videoCard * 250;
double processorPrice = processor * (videoCardPrice * 0.35);
double ramPrice = ram * (videoCardPrice * 0.1);
double bill = videoCardPrice + processorPrice + ramPrice;
if  (videoCard > processor)
{
    bill = bill - bill * 0.15;
}
if (budget >= bill)
{
    double bugetLeft = budget - bill;
    Console.WriteLine($"You have {bugetLeft:F2} leva left!");
}
else
{
    double neededBudget = bill - budget;
    Console.WriteLine($"Not enough money! You need {neededBudget:F2} leva more!");
}