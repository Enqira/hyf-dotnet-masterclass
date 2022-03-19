// Task 2
var time = new JupiterTime(8, 46);
time.Hours = 3;
//time.Minutes = 38;

PrintTime(time);

void PrintTime(JupiterTime time)
{
    string f = "00.##";
    Console.WriteLine($"{time.Hours.ToString(f)}:{time.Minutes.ToString(f)}");
}
public class JupiterTime
{
    int _hours = 0, _minutes = 0;

    // Constructor
    public JupiterTime(int hours = 0, int minutes = 0)
    {
        if (hours > 9)
        {
            _hours = hours % 10;
        }
        else _hours = hours;
        if (minutes > 59)
        {
            _hours += minutes / 60;
            _minutes = minutes % 60;
        }
        else _minutes = minutes;
    }


    // Hours Prop
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            _hours += value;
            if (_hours > 9) _hours = _hours % 10;
        }
    }

    // Minutes Prop
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            //check if minutes is more than 59, and if so add the exeeding minutes to hours (eack hour is 60 minutes)
            _minutes += value;
            if (_minutes > 59)
            {
                _hours += _minutes / 60;
                _minutes = _minutes % 60;
            }


        }
    }
}
