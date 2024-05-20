using System;

class Program
{
    static void Main()
    {
        // Входни данни
        double budget = double.Parse(Console.ReadLine());
        int numberOfActors = int.Parse(Console.ReadLine());
        double pricePerClothing = double.Parse(Console.ReadLine());

        // Изчисления
        double decorCost = budget * 0.1;
        double clothingCost = pricePerClothing * numberOfActors;

        // Проверка за отстъпка при повече от 150 статисти
        if (numberOfActors > 150)
        {
            clothingCost -= clothingCost * 0.1;
        }

        double totalCost = decorCost + clothingCost;

        // Изход
        if (totalCost > budget)
        {
            double neededMoney = totalCost - budget;
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
        }
        else
        {
            double moneyLeft = budget - totalCost;
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
        }
    }
}
