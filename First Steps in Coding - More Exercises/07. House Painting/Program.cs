﻿double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double frontAndBackWall = (x * x) * 2 - 1.2 * 2;
double sideWalls = (x * y) * 2 - 2 * (1.5 * 1.5);
double sideRoof = (x * y) * 2;
double frontAndBackRoof = (x * h / 2) * 2;
double redPaintNeeded = (sideRoof + frontAndBackRoof) / 4.3;
double greenPaintNeeded = (frontAndBackWall + sideWalls) / 3.4;
Console.WriteLine($"{greenPaintNeeded:f2}");
Console.WriteLine($"{redPaintNeeded:f2}");
