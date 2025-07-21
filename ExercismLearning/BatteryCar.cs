class RemoteControlCar
{
    public int battery = 100;
    public int mileage = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {mileage} meters";

    public string BatteryDisplay() => battery == 0 ? "Battery empty" : $"Battery at {battery}%";

    public void Drive()
    {
        if (battery != 0)
        {
            battery -= 1;
            mileage += 20;
        }
    }
}
