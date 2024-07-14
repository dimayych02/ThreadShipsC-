using ThreadShips.Ship;

namespace ThreadShips.Ship
{
    public enum ShipType
    {
        ХЛЕБ,
        БАНАН,
        ОДЕЖДА
    }
}


namespace ThreadShips
{

    internal class ShipModel
    {
        private readonly ShipType? shipType;
        private readonly int capacity;
        private readonly int shipNumber;

        public ShipModel(ShipType? shipType, int capacity, int shipNumber)
        {
            this.shipType = shipType;
            this.capacity = capacity;
            this.shipNumber = shipNumber;
        }

        public ShipType? GetShipType { get => shipType; }
        public int Capacity { get => capacity; }
        public int ShipNumber { get => shipNumber; }


        public void Deconstruct(out ShipType? shipType, out int capacity, out int shipNumber)
        {
            shipType = this.shipType;
            capacity = this.capacity;
            shipNumber = this.shipNumber;
        }
    }
}
