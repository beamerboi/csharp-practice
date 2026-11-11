class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int batteryLevel = 100;
    private int distance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        distance = 0;
    }

    public bool BatteryDrained()
    {
        return batteryLevel < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }
        distance += speed;
        batteryLevel -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

    public int getBatteryLevel()
    {
        return batteryLevel;
    }

    public int getSpeed()
    {
        return speed;
    }

    public int getBatteryDrain()
    {
        return batteryDrain;
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maxDistance = car.getBatteryLevel() / car.getBatteryDrain() * car.getSpeed();
        if (maxDistance >= distance)
        {
            return true;
        }
        return false;
    }
}
