using ThreadShips.Ship;

namespace ThreadShips.Helpers
{
    internal class RandomHelper
    {
        private static Random random = new Random();
     
        // Генерация вместимости корабля
        public static int GenerateShipCapacity()
        {
            const int MIN_CAPACITY = 10;
            const int MAX_CAPACITY = 100;
            const int STEP = 10;
            var randomCapacity = random.Next((MAX_CAPACITY - MIN_CAPACITY) / STEP + 1) * STEP + MIN_CAPACITY;
            return randomCapacity;
        }

    
        // Генерируем рандомный вид корабля: ХЛЕБ, БАНАН. ОДЕЖДА
        public static ShipType? GenerateShipType()
        {
            var values = Enum.GetValues(typeof(ShipType));
            var value = values.GetValue(random.Next(values.Length));

            if (value is ShipType shipType)
                return shipType;
           return null;
        }
    }
}
