string figure = Console.ReadLine();
if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", side * side);
}
else if (figure == "rectangle")
{
    double side1 = double.Parse(Console.ReadLine());
    double side2 = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", side1 * side2);
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", radius * Math.PI * radius);
}
else if (figure == "triangle")
{
    double aSide = double.Parse(Console.ReadLine());
    double hASide = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", (aSide * hASide) / 2);
}