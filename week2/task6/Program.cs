// Task 6
var time = new JupiterTime(2, 70);
//time.AddMinutes(20);
Console.WriteLine(time);

//Signaler 

// var signaler = new Signaler();
// signaler.AddTime(new JupiterTime(1, 20));
// signaler.AddTime(new JupiterTime(2, 20));
// signaler.AddTime(new JupiterTime(3, 20));

// signaler.Inform();
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
        // handle minutes greater than 59.
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


// Signaler Class
public class Signaler
{
    public List<JupiterTime> timers { get; set; } = new List<JupiterTime>();
    public void AddTime(JupiterTime time)
    {
        timers.Add(time);
    }

    public void Inform()
    {
        if (timers.Count > 0)
        {
            foreach (var time in timers)
            {
                Console.WriteLine(time.ToString());
            }
        }
        else
        {
            Console.WriteLine("No timers added yet.");
        }
    }
}
