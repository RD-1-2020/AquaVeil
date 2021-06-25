using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeilV1
{
    static class Settings
    {
        static private Int32 _width = 100;
        static private Int32 _height = 100;

        /// <summary>
        /// Ширина кадра
        /// </summary>
        public static int Width { get => _width; set => _width = value; }

        /// <summary>
        /// Высота кадра
        /// </summary>
        public static int Height { get => _height; set => _height = value; }

        static private Int32 _widthPix = 15;
        static private Int32 _heightPix = 15;

        /// <summary>
        /// Ширина пикселя кадра
        /// </summary>
        public static int WidthPix { get => _widthPix; set => _widthPix = value; }

        /// <summary>
        /// Высота пикселя кадра
        /// </summary>
        public static int HeightPix { get => _heightPix; set => _heightPix = value; }
    }
}
