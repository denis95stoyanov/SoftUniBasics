double moneyNeededForVacation = double.Parse(Console.ReadLine());
double moneyOwned = double.Parse(Console.ReadLine());
int pastDays = 0;
int spendMoney = 0;
while (moneyOwned < moneyNeededForVacation && spendMoney < 5)
{
    string comand = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    pastDays++;
    if (comand == "save")
    {
        moneyOwned += money;
        spendMoney = 0;
    }
    else if (comand == "spend")
    {
        moneyOwned -= money;
        spendMoney++;
    }
    if (moneyOwned <= 0)
    {
        moneyOwned = 0;
    }
}
if (spendMoney == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(pastDays);
}
else if (moneyOwned >= moneyNeededForVacation)
{
    Console.WriteLine($"You saved the money for {pastDays} days.");
}
