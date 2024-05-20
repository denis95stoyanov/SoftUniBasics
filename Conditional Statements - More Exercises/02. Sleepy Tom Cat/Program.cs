int freeDays = int.Parse(Console.ReadLine());
int TomPlayTime = 30000;
int ownerWorkDays = 365 - freeDays;
int totalPlayedTime = ownerWorkDays * 63 + freeDays * 127;
int differenceInPlyTime = Math.Abs(TomPlayTime - totalPlayedTime);
int hours = differenceInPlyTime / 60;
int minutes = differenceInPlyTime % 60;
if (totalPlayedTime > TomPlayTime)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes:D2} minutes more for play");
}
else if (totalPlayedTime <= TomPlayTime)
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes:D2} minutes less for play");
}