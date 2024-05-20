double priceForKiloVegetables = double.Parse(Console.ReadLine());
double priceForKiloFruits = double.Parse(Console.ReadLine());
int kiloVegetables =  int.Parse(Console.ReadLine());
int kiloFruits = int.Parse(Console.ReadLine());
double billVegetables = priceForKiloVegetables * kiloVegetables;
double billFruits = priceForKiloFruits * kiloFruits;
double finalPrice = billFruits + billVegetables;
double euro = finalPrice / 1.94;
Console.WriteLine($"{euro:F2}");