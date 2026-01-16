namespace TrafficManager
{
    class TrafficManagermain
    {
        static void Main(string[] args)
        {
            TrafficManager tm = new TrafficManager();
            tm.AddWaitingCar("123");
            tm.AddWaitingCar("456");
            tm.EnterRoundabout();
            tm.EnterRoundabout();
            tm.AddWaitingCar("789");
            tm.EnterRoundabout();
            tm.RemoveFromRoundabout("456");
            tm.DisplayRoundabout();
            tm.AddWaitingCar("101");
            tm.DisplayQueue();
        }
    }

}