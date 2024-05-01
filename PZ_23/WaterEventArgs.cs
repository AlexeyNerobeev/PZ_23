using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_23
{
    /// <summary>
    /// Класс для хранения информации о уровне воды
    /// </summary>
    internal class WaterEventArgs
    {
        public int WaterLevel { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="waterLevel">Уровень воды</param>
        public WaterEventArgs(int waterLevel)
        {
            WaterLevel = waterLevel;
        }
    }
}
