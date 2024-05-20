int tournaments = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());
int finalPoints = startPoints;
double winTournaments = 0;
int w = 0; int f = 0; int sF = 0;
for (int stage = 1; stage <= tournaments; stage++)
{
    string stageOfTournament = Console.ReadLine();
    switch (stageOfTournament)
    {
        case "W": finalPoints += 2000; break;
        case "F": finalPoints += 1200; break;
        case "SF": finalPoints += 720; break;
    }
    if (stageOfTournament == "W")
    {
        winTournaments+= 1;
        w += 2000;
    }
    else if (stageOfTournament == "F")
        f += 1200;
    else if (stageOfTournament == "SF")
        sF += 720;
}
double percent = (winTournaments / tournaments) * 100;
double averagePoints = (w + f + sF) / (double)tournaments;
Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percent:f2}%");
