int pages = int.Parse(Console.ReadLine());
int pagePerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int hourForReadBook = pages / pagePerHour;
int hourPerDay = hourForReadBook / days;
Console.WriteLine(hourPerDay);