using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeil.GeneralClasses
{
    public class Settings
    {
        private int width;
        private int height;
        private int count;

        public Settings(int width, int height, int count)
        {
            this.width = width;
            this.height = height;
            this.count = count;
        }

        /// <summary>
        /// Ширина кадра
        /// </summary>
        public int Width { get => width; set => width = value; }
        /// <summary>
        /// Высота Кадра
        /// </summary>
        public int Height { get => height; set => height = value; }
        /// <summary>
        /// Количество кадров
        /// </summary>
        public int Count { get => count; set => count = value; }
    }
}
