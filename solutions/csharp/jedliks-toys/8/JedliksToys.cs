class RemoteControlCar
{
    public int Distance { get; set; } = 0;
    public int Battery { get; set; } = 100;

    public RemoteControlCar()
    {
    }

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {this.Distance} meters";

    public string BatteryDisplay() => this.Battery > 0 ? $"Battery at {this.Battery}%" : "Battery empty";

    public void Drive()
    {
        if (this.Battery > 0)
        {
            this.Distance += 20;
            this.Battery -= 1;
        }
    }
}
