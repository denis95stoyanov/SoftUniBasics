int n = int.Parse(Console.ReadLine());
string nameOfPresentation = Console.ReadLine();
double sumAllPresentations = 0;
int allPresentations = 0;
while (nameOfPresentation != "Finish")
{
    double gradesFromPresentation = 0;

    for (int i = 1; i <= n; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradesFromPresentation += grade;
        sumAllPresentations += grade;
        allPresentations ++;
    }
    Console.WriteLine($"{nameOfPresentation} - {gradesFromPresentation / n:f2}.");
    nameOfPresentation = Console.ReadLine();
}
Console.WriteLine($"Student's final assessment is {sumAllPresentations / allPresentations:f2}.");