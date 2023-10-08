using Task;

internal class Program
{
    private static void Main(string[] args)
    {
        Minivan van1 = new Minivan()
        {
            LicencePlate = "AP 65765"
        };
        Car van2 = new Minivan() { LicencePlate = "AO 76543"};

        var manager = new CarManager<Car>();
        manager.AddCarToParking(van1);

        Console.WriteLine(van1.GetNumberOfSeats());
        Console.WriteLine(van1.GetYear());
        Console.WriteLine(van2.GetNumberOfSeats());
        Console.WriteLine(van2.GetYear());

        Console.WriteLine(van1.GetLicencePlate());
        Console.WriteLine(van1.GetRace());

        Console.WriteLine(manager.GetFullPropertyInfo(van1));
    }
}