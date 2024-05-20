//От конзолата се четат 3 реда:
//1.Депозирана сума – реално число в интервала [100.00 … 10000.00]
double deposit = double.Parse(Console.ReadLine());
//2.Срок на депозита(в месеци) – цяло число в интервала [1…12]
int months = int.Parse(Console.ReadLine());
//3.Годишен лихвен процент – реално число в интервала [0.00 …100.00]
double percent = double.Parse(Console.ReadLine());
//сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
double sum = deposit + months * ((deposit * (percent / 100)) / 12);
//Изход
//Да се отпечата на конзолата сумата в края на срока
Console.WriteLine(sum);