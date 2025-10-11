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
        if (this.Battery == 0)
        {
            return "Battery empty";
        }

        return $"Driven {this.Distance} meters";
    }

    public string BatteryDisplay()
    {
        return $"Battery at {this.Battery}%";
    }

    public void Drive()
    {
        this.Distance += 20;
        this.Battery -= 1;
    }
}
