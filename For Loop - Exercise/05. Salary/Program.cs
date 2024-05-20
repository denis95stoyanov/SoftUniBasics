int openTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());
int moneyLeft = salary;
for (int tabs = 1; tabs <= openTabs; tabs++)
{
    string web = Console.ReadLine();
    if (web == "Facebook")
        moneyLeft -= 150;
    else if (web == "Instagram")
        moneyLeft -= 100;
    else if (web == "Reddit")
        moneyLeft -= 50;
    if (moneyLeft <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}
if (moneyLeft > 0) Console.WriteLine($"{moneyLeft}");