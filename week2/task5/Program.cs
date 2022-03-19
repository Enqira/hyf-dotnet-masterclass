// Task 5
var time = new JupiterTime(2, 20);
time.AddMinutes(20);

Console.WriteLine(time);

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
            //check if hours is more than 9, and if so start from 0 hours
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
    // Add hours method
    public int AddHours(int hours)
    {
        _hours += hours;

        // Hanlde negative hours, 
        if (_hours < 0) _hours += System.Math.Abs(_hours - (_hours % 10) - 10);
        if (_hours > 9) _hours = _hours % 10;

        return _hours;
    }

    // Add minutes mehtod
    public int AddMinutes(int minutes)
    {
        _minutes += minutes;

        // handle negative minutes.
        if (_minutes < 0)
        {
            _hours -= System.Math.Abs(minutes) / 60 + 1;
            _minutes += System.Math.Abs(_minutes - (_minutes % 60) - 60);
        }
        // handle minutes greater than  59.
        if (_minutes > 59)
        {
            _hours += _minutes / 60;
            _minutes = _minutes % 60;
        }
        return _minutes;
    }

    // Print time
    public override string ToString()
    {
        string f = "00.##";
        return $"{_hours.ToString(f)}:{_minutes.ToString(f)}";
    }
}
