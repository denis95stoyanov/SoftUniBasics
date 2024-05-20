int years = int.Parse(Console.ReadLine());
double washMashinePrice = double.Parse(Console.ReadLine());
int toyPrice =  int.Parse(Console.ReadLine());
double savings = 0;
for (int birthday = 1; birthday <= years; birthday++)
{
    if (birthday % 2 == 0)
    {
        savings += birthday * 5 - 1;
    }
    else
    {
        savings += toyPrice;
    }
}
if (savings >= washMashinePrice)
    Console.WriteLine($"Yes! {savings - washMashinePrice:f2}");
else
    Console.WriteLine($"No! {washMashinePrice - savings:f2}");