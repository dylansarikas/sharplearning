class RemoteControlCar
{
    private int battery = 100;
    public int speed;
    public int batteryDrain;
    private int mileage;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => (battery < batteryDrain) ? true : false;

    public int DistanceDriven() => mileage;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            battery -= batteryDrain;
            mileage += speed; 
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
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
        int laps = 100 / car.batteryDrain;
        int potential = laps * car.speed;
        return (potential >= distance);
    }
}
