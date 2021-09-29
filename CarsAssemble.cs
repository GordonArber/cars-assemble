using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        double ratePerHour = 0.0;
        if (speed >= 1 && speed <=4)
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
        return (int)ProductionRatePerHour(speed) * 221;
    }
}
