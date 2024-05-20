double sqm = double.Parse(Console.ReadLine());
double priceSQM = 7.61 * sqm;
double discount = 0.18 * priceSQM;
double endPrice = priceSQM - discount;
Console.WriteLine($"The final price is: {endPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");