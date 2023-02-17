namespace Hestia_Commons
{
    public class Property
    {
        /**
         * Identifier given by the source
         **/
        public string GivenIdentifier { get; set; }

        public Address Address { get; set; }

        public byte NumberOfRooms { get; set; }

        public byte NumberOfBathrooms { get; set; }

        public short LivableSpace { get; set; }

        public short Land { get; set; }

        public EPC EPCScore { get; set; }

        public Condition Condition { get; set; }

        public FloodZoneStatus FloodZone { get; set; }

        public double Price { get; set; }

    }
}
