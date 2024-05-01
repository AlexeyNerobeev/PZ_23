namespace PZ_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterReservoir reservoir = new WaterReservoir(1000);
            Monitor monitor = new Monitor(reservoir);

            reservoir.AddWater(500);
            reservoir.AddWater(600);
            reservoir.ReleaseWater();
            reservoir.ReleaseWater();
        }
    }
}
