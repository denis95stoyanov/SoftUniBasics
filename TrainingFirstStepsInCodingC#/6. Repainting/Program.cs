﻿double plastic = double.Parse(Console.ReadLine());
double paint  = double.Parse(Console.ReadLine());
double spliter  = double.Parse(Console.ReadLine());
double hours  = double.Parse(Console.ReadLine());
double plasticPrice = (plastic + 2) * 1.50;
double paintPrice = (paint + (paint *0.10)) * 14.50;
double spliterPrice = spliter * 5.00;
double bagPrice = 0.40;
double price = plasticPrice + paintPrice +  spliterPrice + bagPrice;
double peoplePrice = (price * 0.30) * hours;
double sum = price + peoplePrice;
Console.WriteLine(sum);