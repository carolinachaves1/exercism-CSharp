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
        return this.Battery > 0 ? $"Driven {this.Distance} meters" : "Battery empty";
    }

    public string BatteryDisplay()
    {
        return $"Battery at {this.Battery}%";
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
