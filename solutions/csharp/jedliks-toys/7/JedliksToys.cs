class RemoteControlCar
{
    public int Distance { get; set; }
    public int Battery { get; set; }

    public RemoteControlCar()
    {
        Distance = 0;
        Battery = 100;
    }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this.Distance} meters";
    }

    public string BatteryDisplay()
    {
        return this.Battery > 0 ? $"Battery at {this.Battery}%" : "Battery empty";
    }

    public void Drive()
    {
        if (this.Battery > 0)
        {
            this.Distance += 20;
            this.Battery -= 1;
        }
    }
}
