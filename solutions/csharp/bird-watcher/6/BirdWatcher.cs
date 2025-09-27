class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public int IncrementTodaysCount()
    {
        int today = birdsPerDay.Length - 1;
        return today++;
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
