double swimmingRecordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters =  double.Parse(Console.ReadLine());
double timeInSecondsForMeter =  double.Parse(Console.ReadLine());
double newRecord = distanceInMeters * timeInSecondsForMeter;
double resistenceOfWater = Math.Floor(distanceInMeters / 15) * 12.5;
double sumTime = (newRecord + resistenceOfWater);
if (swimmingRecordInSeconds > sumTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {sumTime:F2} seconds.");
}
else
{
    double neededSeconds = Math.Abs(swimmingRecordInSeconds - sumTime);
    Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
}