using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_23
{
    /// <summary>
    /// Класс для управления объемом воды в водохранилище
    /// </summary>
    internal class WaterReservoir
    {
        public int Volume { get; set; }
        public int MaxVolume { get; set; }
        public int dropWater { get; set; }

        public event EventHandler<WaterEventArgs> WaterLevelChanged;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxVolume">Максимальный объем водохранилища</param>
        public WaterReservoir(int maxVolume)
        {
            MaxVolume = maxVolume;
            Volume = 0;
            dropWater = 200;
        }

        /// <summary>
        /// Метод для добавления воды
        /// </summary>
        /// <param name="amount">Количество воды для добавления</param>
        public void AddWater(int amount)
        {
            Volume += amount;
            Console.WriteLine($"Добавление воды: {amount}. Текущий объем воды: {Volume}");
            if (Volume >= MaxVolume)
            {
                Console.WriteLine("Водохранилище полное!");
                Volume = MaxVolume;
            }
            OnWaterLevelChanged();  
        }

        /// <summary>
        /// Метод для сброса воды
        /// </summary>
        public void ReleaseWater()
        {
            Volume -= dropWater;
            Console.WriteLine($"Сброс воды: {dropWater}. Текущий объем воды: {Volume}");
            if (Volume <= 0)
            {
                Console.WriteLine("Водохранилище пусто.");
                Volume = 0;
            }
            OnWaterLevelChanged();
        }

        /// <summary>
        /// Метод для понижения сброса воды
        /// </summary>
        public void DecreaseDropWater()
        {
            dropWater = 200;
        }

        /// <summary>
        /// Метод для повышения сброса воды
        /// </summary>
        public void AddDropWater()
        {
            dropWater += 200;
        }

        /// <summary>
        /// Метод для вызова события изменения уровня воды
        /// </summary>
        public void OnWaterLevelChanged()
        {
            WaterLevelChanged?.Invoke(this, new WaterEventArgs(Volume));
        }
    }
}
