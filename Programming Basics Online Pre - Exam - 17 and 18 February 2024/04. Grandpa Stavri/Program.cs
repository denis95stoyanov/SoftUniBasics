int n = int.Parse(Console.ReadLine());
double rakiaSum = 0;
double degreesSum = 0;
for (int i = 1; i <= n; i++)
{
    double rakia = double.Parse(Console.ReadLine());
    double degrees = double.Parse(Console.ReadLine());
    rakiaSum += rakia;
    degreesSum += rakia * degrees;
}
double avaregeValueDegrees = degreesSum / rakiaSum;
Console.WriteLine($"Liter: {rakiaSum:f2}");
Console.WriteLine($"Degrees: {avaregeValueDegrees:f2}");
if (avaregeValueDegrees < 38)
    Console.WriteLine("Not good, you should baking!");
else if (avaregeValueDegrees >= 38 && avaregeValueDegrees <= 42)
    Console.WriteLine("Super!");
else Console.WriteLine("Dilution with distilled water!");