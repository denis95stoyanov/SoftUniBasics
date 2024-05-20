string favoriteBook = Console.ReadLine();
int counter = 0;
bool isBookFound = false;
string nextBookFound = Console.ReadLine();
while (nextBookFound != "No More Books")
{
    if (nextBookFound == favoriteBook)
    {
        isBookFound = true;
        break;
    }
    counter++;
    nextBookFound = Console.ReadLine();
}
if (!isBookFound)
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {counter} books.");
}
else Console.WriteLine($"You checked {counter} books and found it.");
