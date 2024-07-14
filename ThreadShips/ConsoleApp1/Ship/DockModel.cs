namespace ThreadShips.Ship
{
    internal class DockModel
    {

        private readonly ShipType dockType;

        public DockModel(ShipType ship)
        {
            dockType = ship;
        }

        public ShipType DockType { get => dockType; }

        public void LoadShip(ShipModel ship)
        {
            try
            {
                if(DockType != ship.GetShipType)
                {
                    Console.WriteLine($"Корабль [{ship.GetShipType}] ошибочно загружается от причала [{DockType}]...");
                    return;
                }

                int remainingCapacity = ship.Capacity;

                while (remainingCapacity > 0)
                {

                    Console.WriteLine("Загрузка товара...");
                    Thread.Sleep(1000);
                    remainingCapacity -= 10;
                    Console.WriteLine($"Причал [{DockType}] загрузил 10 товаров для корабля [{ship.GetShipType}-{ship.ShipNumber}]. Осталось загрузить: [{remainingCapacity}]... ");
                }
 
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Возникла ошибка при загрузке корабля: {ex.Message}");
            }
        }
    }
}
