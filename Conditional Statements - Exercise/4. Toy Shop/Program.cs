using System;

class Program
{
    static void Main()
    {
        // Входни данни
        double tripPrice = double.Parse(Console.ReadLine());
        int puzzle = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        // Цени на играчките
        double puzzlePrice = puzzle * 2.6;
        double dollsPrice = dolls * 3;
        double bearsPrice = bears * 4.1;
        double minionsPrice = minions * 8.2;
        double trucksPrice = trucks * 2;

        // Общ доход и брой продадени играчки
        double income = puzzlePrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;
        int toysNum = puzzle + dolls + bears + minions + trucks;

        // Отстъпка за повече от 50 играчки
        if (toysNum >= 50)
        {
            income -= income * 0.25;
        }

        // Рентата
        double rent = income * 0.1;
        double finalIncome = income - rent;

        // Проверка за възможност да се позволи пътуването
        if (finalIncome >= tripPrice)
        {
            double moneyLeft = finalIncome - tripPrice;
            Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
        }
        else
        {
            double priceForTrip = tripPrice - finalIncome;
            Console.WriteLine($"Not enough money! {priceForTrip:F2} lv needed.");
        }
    }
}
