namespace Task
{
    public class CarManager<T> where T : Car
    {
        private List<string> parking = new List<string>();

        private bool IsAvailableOnParking(T car) => parking.Exists(lp => lp == car.LicencePlate);

        public string GetFullPropertyInfo(T car)
        {
            string IsCarOnParking = IsAvailableOnParking(car) ? "Car is on parking" : "Car is not present on parking";

            return $"Number of seats : {car.GetNumberOfSeats()}" +
                   $"\nYear : {car.GetYear()}\nRace : {car.GetRace()}" +
                   $"\n{IsCarOnParking}";
        }

        public void AddCarToParking(T car)
        {
            if(parking.Count < 51)
            {
                parking.Add(car.LicencePlate);
            }
        }
    }
}
