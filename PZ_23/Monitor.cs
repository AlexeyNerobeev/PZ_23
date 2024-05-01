using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_23
{
    /// <summary>
    /// Класс для наблюдения за уровнем воды в водохранилище
    /// </summary>
    internal class Monitor
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// /// <param name="reservoir">Водохранилище</param>
        public Monitor(WaterReservoir reservoir)
        {
            reservoir.WaterLevelChanged += (sender, args) =>
            {
                if (args.WaterLevel > 0.95 * reservoir.MaxVolume)
                {
                    Console.WriteLine("Увеличение сброса воды");
                    reservoir.AddDropWater();
                }
                else if (args.WaterLevel < 0.7 * reservoir.MaxVolume)
                {
                    Console.WriteLine("Уменьшение сброса воды");
                    reservoir.DecreaseDropWater();
                }
            };
        }
    }
}
