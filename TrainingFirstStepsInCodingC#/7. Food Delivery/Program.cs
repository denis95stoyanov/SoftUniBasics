﻿double chickenMenu = double.Parse(Console.ReadLine());
double fishMenu  = double.Parse(Console.ReadLine());
double veggiMenu  = double.Parse(Console.ReadLine());
double chickenMenuPrice = chickenMenu * 10.35;
double fishMenuPrice = fishMenu * 12.40;
double veggiMenuPrice = veggiMenu * 8.15;
double delivery = 2.50;
double price = chickenMenuPrice + fishMenuPrice + veggiMenuPrice;
double desertPrice = price * 0.20;
double sum = price + desertPrice + delivery;
Console.WriteLine(sum);