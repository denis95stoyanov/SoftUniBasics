string actorName = Console.ReadLine();
double score = double.Parse(Console.ReadLine());
int valuer = int.Parse(Console.ReadLine());
double actorPoints = score;
for (int valuers = 1; valuers <= valuer; valuers++)
{
    string valuerName = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());
    int namePoints = valuerName.Length;
    actorPoints += (points * namePoints) / 2;
    if (actorPoints > 1250.5)
    { Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {actorPoints:f1}!");
        break;
    }
}
if (actorPoints < 1250.5)
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - actorPoints:f1} more!");