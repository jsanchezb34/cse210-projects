
public class Swimming : Activity
{
    private int _laps; 
    private const double LapDistance = 0.05; 

    public Swimming(DateTime date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapDistance; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; 
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); 
    }

}