// Task 1
var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 5;

PrintTime(time);

void PrintTime(JupiterTime time)
{
    string f = "00.##";
    Console.WriteLine($"{time.Hours.ToString(f)}:{time.Minutes.ToString(f)}");
}
public class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
}
