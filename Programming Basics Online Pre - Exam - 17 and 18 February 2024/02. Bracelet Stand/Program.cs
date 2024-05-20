double pocketMoneyTeresa = double.Parse(Console.ReadLine());
double moneyProfitForDay = double.Parse(Console.ReadLine());
double moneyForCostsAllTiime = double.Parse(Console.ReadLine());
double priceForPresent = double.Parse(Console.ReadLine());
int days = 5;
double savedPocketMoney = pocketMoneyTeresa * days;
double earnedMoney = moneyProfitForDay * days;
double savedMoneySum = savedPocketMoney + earnedMoney - moneyForCostsAllTiime;
if (savedMoneySum >= priceForPresent)
    Console.WriteLine($"Profit: {savedMoneySum:f2} BGN, the gift has been purchased.");
else Console.WriteLine($"Insufficient money: {(priceForPresent - savedMoneySum):f2} BGN.");