using System;

static class AssemblyLine
{
    const int BASE_PRODUCTION_RATE = 221;
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * BASE_PRODUCTION_RATE * SuccessRate(speed);
    }
    static double SuccessRate(int speed)
    {
        double ratePerHour = 0.0;
        if (speed is >= 1 and <= 4)
        {
            ratePerHour = 1.0;
        } else if (speed >= 5 && speed <=8)
        {
            ratePerHour = .9;
        }else if (speed == 9)
        {
            ratePerHour = .8;
        }else if (speed == 10)
        {
            ratePerHour = .77;
        }
        return ratePerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed)/60;
    }
}
