namespace Hestia_Commons
{
    public class Address
    {
        private string streetName;
        private string cityName;
        private short zipCode;
        private string number;

        public Address(string streetName, string cityName, short zipCode, string number, (double, double)? coordinates)
        {
            StreetName = streetName;
            City = cityName;
            ZipCode = zipCode;
            Number = number;
            Coordinates = coordinates;
        }

        public string StreetName { get => streetName; set => streetName = value; }
        public string City { get => cityName; set => cityName = value; }
        public short ZipCode { get => zipCode; set => zipCode = value; }

        public string Number { get => number; set => number = value; }

        public (double, double)? Coordinates { get; set; }


    }
}
