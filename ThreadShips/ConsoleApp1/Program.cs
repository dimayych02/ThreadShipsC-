using ThreadShips.Helpers;
using ThreadShips.Ship;
namespace ThreadShips
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var tunnel = new TunnelModel(3, 3);
            var breadDock = new DockModel(ShipType.ХЛЕБ);
            var bananaDock = new DockModel(ShipType.БАНАН);
            var clothesDock = new DockModel(ShipType.ОДЕЖДА);

            for(int i = 1; i <= 10; i++)
            {
                var randShipType = RandomHelper.GenerateShipType();
                var randomCapacity = RandomHelper.GenerateShipCapacity();
                var ship = new ShipModel(randShipType, randomCapacity, i);

                (ShipType? shipType, int capacity, int shipNumber) = ship;

                var dock = randShipType switch
                {
                    ShipType.ХЛЕБ => breadDock,
                    ShipType.БАНАН => bananaDock,
                    ShipType.ОДЕЖДА => clothesDock,
                    _ => null
                };

                var thread = new Thread(() =>
                {
                    
                    Thread.Sleep(500);
                    Console.WriteLine("-------");
                    Console.WriteLine($"Корабль [{shipType}] с вместимостью [{capacity}] и идентификатором [{shipNumber}] готовится войти в туннель...");
                    tunnel.EnterTunnel();

                    Console.WriteLine("-------");
                    Console.WriteLine($"Корабль [{shipType}] с вместимостью [{capacity}] и идентификатором [{shipNumber}] готовится к загрузке товара...");
                    dock?.LoadShip(ship);

                    tunnel.ExitTunnel();
                    Console.WriteLine("-------");
                    Console.WriteLine($"Корабль [{shipType}] с вместимостью [{capacity}] и идентификатором [{shipNumber}] покинул туннель  ...");
                });

                thread.Start();
            }
            
        }
    }
    
}