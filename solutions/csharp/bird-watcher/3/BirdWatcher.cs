class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public int[] LastWeek()
    {
        return birdsPerDay;
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        int today = Today();
        today++;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.Exists(birdsPerDay, count => count == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(count => count >= 5);
    }
}
