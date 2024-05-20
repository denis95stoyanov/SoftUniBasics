﻿int fatsPercent = int.Parse(Console.ReadLine());
int proteinPercent = int.Parse(Console.ReadLine());
int carbohydratesPersent = int.Parse(Console.ReadLine());
int calories = int.Parse(Console.ReadLine());
int waterPercent = int.Parse(Console.ReadLine());
double fatsGrams = ((calories * (fatsPercent / 100.0)) / 9.0);
double proteinGrams = ((calories * (proteinPercent / 100.0)) / 4.0);
double carbohydratesGrams = ((calories * (carbohydratesPersent / 100.0)) / 4.0);
double gramsInTotal = fatsGrams + proteinGrams + carbohydratesGrams;
double caloriesPerGramFood = calories / gramsInTotal;
double waterPerGramFood = caloriesPerGramFood * (waterPercent / 100.0);
double caloriesPerGram = caloriesPerGramFood - waterPerGramFood;
Console.WriteLine($"{caloriesPerGram:f4}");