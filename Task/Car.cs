public abstract class Car
{
    public abstract required string LicencePlate { get; init; }
    public int NumberOfSeats { get; set; }
    public int Year { get; set; }

    public abstract int GetRace();
    public virtual int GetNumberOfSeats()
    {
        return NumberOfSeats;
    }

    public int GetYear() => DateTime.Now.Year - 10;

}