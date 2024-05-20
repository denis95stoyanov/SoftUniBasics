int firsNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
for (int i = firsNumber; i <= secondNumber; i++)
{
    string currentNumber = i.ToString();
    int odd = 0;
    int even = 0;
    for (int j = 0; j < currentNumber.Length; j++)
    {
        int currentDigit = int.Parse(currentNumber[j].ToString());
        if (j % 2 == 0 ) even+= currentDigit;
        else odd+= currentDigit;
    }
    if (odd == even) Console.Write(i + " ");
}