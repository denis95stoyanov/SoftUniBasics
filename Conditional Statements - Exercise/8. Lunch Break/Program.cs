string titleOfMovie = Console.ReadLine();
int episodeLenght = int.Parse(Console.ReadLine());
int breakLenght = int.Parse(Console.ReadLine());
double lunchTime = breakLenght * 0.125;
double restTime = breakLenght * 0.25;
double timeLeftForEpisode = breakLenght - lunchTime - restTime;
if (timeLeftForEpisode >= episodeLenght)
{
    double timeLeft = Math.Ceiling(timeLeftForEpisode - episodeLenght);
    Console.WriteLine($"You have enough time to watch {titleOfMovie} and left with {timeLeft} minutes free time.");
}
else
{
    double timeNeeded = Math.Ceiling(episodeLenght - timeLeftForEpisode);
    Console.WriteLine($"You don't have enough time to watch {titleOfMovie}, you need {timeNeeded} more minutes.");
}