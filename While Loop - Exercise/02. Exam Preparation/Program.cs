int unsatisfiedGrade = int.Parse(Console.ReadLine());
int failedCounter = 0;
int slovedCounter = 0;
double averageScore = 0;
string lastProblem = "";
bool isFailed = true;
while (failedCounter < unsatisfiedGrade)
{
    string problem = Console.ReadLine();
    if (problem == "Enough")
    {
        isFailed = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4) failedCounter++;
    averageScore += grade;
    slovedCounter++;
    lastProblem = problem;
}
if (isFailed)
    Console.WriteLine($"You need a break, {failedCounter} poor grades.");
else
{
    Console.WriteLine($"Average score: {averageScore / slovedCounter:f2}");
    Console.WriteLine($"Number of problems: {slovedCounter}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
