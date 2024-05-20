int begining = int.Parse(Console.ReadLine());
int ending = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int combinations = 0;
bool isFound = false;
for (int i = begining; i <= ending; i++)
{
    for (int j = begining; j <= ending; j++)
    {
        combinations++;
        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
            isFound = true;
            break; }
    }
    if (isFound) break;
}
if (!isFound) Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");