int hourOfExam = int.Parse(Console.ReadLine());
int minutesOfExam = int.Parse(Console.ReadLine());
int hourOfArrival  = int.Parse(Console.ReadLine());
int minutesOfArrival  = int.Parse(Console.ReadLine());

int examTimeInMinutes = hourOfExam * 60 + minutesOfExam;
int arrivalTimeInMinutes = minutesOfArrival + 60 * hourOfArrival;

int difference =  arrivalTimeInMinutes - examTimeInMinutes;

string status = "";
string timeFormat = "";

if (difference < -30)
{
    status = "Early";
    if (difference < - 59)
    {
        int hours = Math.Abs(difference) / 60;
        int minutes = Math.Abs(difference) % 60;
        timeFormat = $"{hours}:{minutes:D2} hours before the start";
    }
    else
    {
        timeFormat = $"{Math.Abs(difference)} minutes before the start";
    }
}
else if (difference <= 0)
{
    status = "On Time";
    if (difference != 0)
    {
        timeFormat = $"{Math.Abs(difference)} minutes before the start";
    }
}
else 
{
    status = "Late";
    if (difference < 60)
    {
        timeFormat = $"{difference} minutes after the start";
    }
    else
    {
        int hours = difference / 60;
        int minutes = difference % 60;
        timeFormat = $"{hours}:{minutes:D2} hours after the start";
    }
}
Console.WriteLine(status);
if (!string.IsNullOrEmpty(timeFormat))
{
    Console.WriteLine(timeFormat);
}
