while(true)
{
    double num = double.Parse(Console.ReadLine());
    if (num < 0)
    { 
        Console.WriteLine("Negative number!"); break;
    }
    Console.WriteLine($"Result: {num * 2:f2}");
}    