string? input;
var rand = new Random();
int days;

enter:
do
{
    Console.WriteLine("Enter the CORRECT NUMBER of days of the month: ");
    input = Console.ReadLine();
} while (int.TryParse(input, out days) == false);

if (days < 28 || days >31)
{
    goto enter;
}

List<int> lstDays = [..Enumerable.Range(1, days)];
var day = rand.Next(lstDays.Count);

Console.WriteLine($"Your day is: {day}");