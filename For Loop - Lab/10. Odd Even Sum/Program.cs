int n = int.Parse(Console.ReadLine());
int oddPosition = 0;
int evenPositon = 0;
for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
        evenPositon += currentNumber;
    else oddPosition += currentNumber;
}
int difference = Math.Abs(evenPositon - oddPosition);
if (oddPosition == evenPositon)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {oddPosition}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}