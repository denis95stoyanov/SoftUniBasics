int n1 = int.Parse(Console.ReadLine());
int n2  = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());
if (operation == '+' || operation == '-' || operation == '*')
{
    int result = 0;
    string oddOrEven = "odd";
    switch (operation)
    {
        case '+':
            result = n1 + n2; break;
        case '-':
            result = n1 - n2; break;
        case '*':
            result = n1 * n2; break;
            break;
        default: break;
    }
    if (result % 2 == 0) oddOrEven = "even";
    Console.WriteLine($"{n1} {operation} {n2} = {result} - {oddOrEven}");
}
else
{
    if (n2 == 0)
        Console.WriteLine($"Cannot divide {n1} by zero");
    else if (operation == '/')
    {
        double result = (double)n1 / n2;
        Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
    }
    else
    {
        int result = n1 % n2;
        Console.WriteLine($"{n1} {operation} {n2} = {result}");
    }
}