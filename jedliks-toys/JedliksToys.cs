class RemoteControlCar
{
    private int DistanceDriven = 0;
    private int BatteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {DistanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (BatteryPercentage == 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {BatteryPercentage}%";
        }
    }

    public void Drive()
    {
        if (BatteryPercentage > 0)
        {
            DistanceDriven += 20;
            BatteryPercentage -= 1;
        }
    }
}
