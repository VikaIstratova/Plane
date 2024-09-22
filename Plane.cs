namespace Plane
{
    public class Plane
    {

        public string Model;
        public string Producer;
        public int Year;
        public string Type;
        public int MaxPassengers; // Замість "Кількість пасажирів"
        public double MaxFlightRange;  // Замість "Дальність польоту"
        public double MaxSpeed;
        public double Wingsspan;
        public double Length;
        public double Height;
        public double FuelConsumption; // Розхід палива
        public void CalculateMaxFlightRange()
        {
            const double fuelEfficiency = 0.1; // км/л (приблизне значення для пасажирського літака)
            MaxFlightRange = MaxSpeed * fuelEfficiency * FuelConsumption;
        }
        public int Age()
        {
            {
                return DateTime.Now.Year - Year;
            }
        }

    }
}
