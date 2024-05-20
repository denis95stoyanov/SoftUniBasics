string title = Console.ReadLine();
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

while (title != "Finish")
{
    int freeSpaces = int.Parse(Console.ReadLine());
    string ticketType = string.Empty;
    int buyTickets = 0;
    while (buyTickets < freeSpaces)
    {
        ticketType = Console.ReadLine();
        if (ticketType == "End") break;
        buyTickets++;
        if (ticketType == "student") studentTickets++;
        else if (ticketType == "standard") standardTickets++;
        else if (ticketType == "kid") kidTickets++;
    }
    Console.WriteLine($"{title} - {(double)buyTickets / freeSpaces * 100:f2}% full.");

    title = Console.ReadLine();
}
int totalTickets = studentTickets + standardTickets + kidTickets;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");