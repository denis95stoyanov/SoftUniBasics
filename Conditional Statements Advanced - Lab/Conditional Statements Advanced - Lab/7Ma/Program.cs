string day = Console.ReadLine();
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Friday":
        Console.WriteLine("12");
        break;
}
switch (day)
{
    case "Wednesday":
    case "Thursday":
        Console.WriteLine("14");
        break;
}
switch (day)
{
    case "Saturday":
    case "Sunday":
        Console.WriteLine("16");
        break;
}