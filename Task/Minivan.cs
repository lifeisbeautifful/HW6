namespace Task
{
    public class Minivan : Car
    {
        public override required string LicencePlate { get; init; }

        public override int GetNumberOfSeats() => 10;
        public new int GetYear() => base.GetYear() + 1;

        public string GetLicencePlate() => LicencePlate ?? "Licence plate is not available!";

        public override int GetRace() => (DateTime.Now.Year - GetYear()) * 100; 
    }
}
