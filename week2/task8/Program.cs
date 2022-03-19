// Task 8
var time = new TitanTime(2, 4);
Console.WriteLine(time);


public class TitanTime
{
    int _hours = 0, _minutes = 0;

    // Constructor
    public TitanTime(int hours = 0, int minutes = 0)
    {
        if (hours > 899)
        {
            _hours = hours % 900;
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
            if (_hours > 899) _hours = _hours % 899;
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
        if (_hours < 0) _hours += System.Math.Abs(_hours - (_hours % 900) - 900);
        if (_hours > 899) _hours = _hours % 900;

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
        // handle minutes greater than a 59 seconds.
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
        string fHours = "000.##";
        string fMinutes = "00.##";
        return $"{_hours.ToString(fHours)}:{_minutes.ToString(fMinutes)}";
    }
}

