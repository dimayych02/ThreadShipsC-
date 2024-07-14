namespace ThreadShips.Ship
{
    internal class TunnelModel
    {
        private readonly Semaphore semaphore;

        public TunnelModel(int minShips, int maxShips)
        {
            semaphore = new Semaphore(minShips, maxShips);
        }

        // Вход в туннель
        public void EnterTunnel()
        {
            semaphore.WaitOne();
        }

        // Выход из туннеля
        public void ExitTunnel()
        {
            semaphore.Release();
        }
    }
}
