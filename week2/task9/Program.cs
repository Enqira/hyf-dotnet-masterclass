// Task 8
var time = new GanymedeTime(183, 4);
//time.AddHours(995);
//time.AddMinutes(-20);
Console.WriteLine(time);


public class AlienTime
{
    int _hours = 0, _minutes = 0, _hoursInDay = 0;

    // Constructor
    public AlienTime(int hours = 0, int minutes = 0, int hoursInDay = 0)
    {
        if (hours > hoursInDay - 1)
        {
            _hours = hours % hoursInDay;
        }
        else _hours = hours;
        if (minutes > 59)
        {
            _hours += minutes / 60;
            _minutes = minutes % 60;
        }
        else _minutes = minutes;
        _hoursInDay = hoursInDay;
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
            if (_hours > _hoursInDay - 1) _hours = _hours % (_hoursInDay);
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
        if (_hours < 0) return _hours += System.Math.Abs(_hours - (_hours % _hoursInDay) - _hoursInDay);
        if (_hours > _hoursInDay - 1) _hours = _hours % _hoursInDay;

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
        string fHours = _hoursInDay.ToString().Length == 2 ? "00.##" : "000.##";
        string fMinutes = "00.##";
        return $"{_hours.ToString(fHours)}:{_minutes.ToString(fMinutes)}";
    }
}

public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    { }
}

public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }
}

public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }
}