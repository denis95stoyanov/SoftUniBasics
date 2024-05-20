double skumriaPrice = double.Parse(Console.ReadLine());
double cacaPrice = double.Parse(Console.ReadLine());
double palamudKilo = double.Parse(Console.ReadLine());
double safridKilo = double.Parse(Console.ReadLine());
int midiKilo = int.Parse(Console.ReadLine());

double palamudPrice = (skumriaPrice * 0.6 + skumriaPrice) * palamudKilo;
double safridPrice = (cacaPrice * 0.8 + cacaPrice) * safridKilo;
double midiPrice = midiKilo * 7.5;
double sum = palamudPrice + safridPrice + midiPrice;
Console.WriteLine($"{sum:f2}");