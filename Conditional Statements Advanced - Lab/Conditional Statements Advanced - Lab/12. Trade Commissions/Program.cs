string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double volume = 0;
double comission = 0;
if (sales >= 0)
{
   switch (city)
    {
        case "Sofia":
            if (sales <= 500) volume = 0.05;
            else if (sales <= 1000) volume = 0.07;
            else if (sales <= 10000) volume = 0.08;
            else if (sales > 10000) volume = 0.12;
            break;
        case "Varna":
            if (sales <= 500) volume = 0.045;
            else if (sales <= 1000) volume = 0.075;
            else if (sales <= 10000) volume = 0.10;
            else if (sales > 10000) volume = 0.13;
            break;
        case "Plovdiv":
            if (sales <= 500) volume = 0.055;
            else if (sales <= 1000) volume = 0.08;
            else if (sales <= 10000) volume = 0.12;
            else if (sales > 10000) volume = 0.145;
            break;
        default:
            Console.WriteLine("error"); return;
    }
    comission = volume * sales;
    Console.WriteLine($"{comission:F2}");
}
else
{ Console.WriteLine("error"); }