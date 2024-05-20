string name = Console.ReadLine();
int klass = 1;
double allGrades = 0;
int badGrades = 0;
while (klass <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade < 4.00)
    {
        badGrades++;
        if (badGrades < 2)
        {
            continue;
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {klass} grade");
            break;
        }
    }
    klass++;
    allGrades+= currentGrade;
}
if (klass >= 12)
{
    double avarageGrade = allGrades / 12;
    Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
}