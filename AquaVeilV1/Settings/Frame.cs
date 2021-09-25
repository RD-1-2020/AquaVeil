using System;
using System.ComponentModel;

namespace AquaVeilV1.Settings
{
    /// <summary>
    /// Singleton Pattern
    /// Настройки поля и clMap
    /// </summary>
    public class Frame
    {
        static private Int32 _width = 112;
        static private Int32 _height = 3;

        /// <summary>
        /// Ширина кадра
        /// </summary>
        [Category("Поле")]
        [DisplayName("Длинна")]
        public int Width
        {
            get => _width;
            set => _width = value;
        }

        /// <summary>
        /// Высота кадра
        /// </summary>
        [Category("Поле")]
        [DisplayName("Высота")]
        public int Height
        {
            get => _height;
            set => _height = value;
        }

        static private Int32 _widthPix = 15;
        static private Int32 _heightPix = 15;

        /// <summary>
        /// Ширина пикселя кадра
        /// </summary>
        [Category("Пиксель")]
        [DisplayName("Ширина")]
        public int WidthPix
        {
            get => _widthPix;
            set => _widthPix = value;
        }

        /// <summary>
        /// Высота пикселя кадра
        /// </summary>
        [Category("Пиксель")]
        [DisplayName("Высота")]
        [ReadOnly(true)]
        public int HeightPix
        {
            get => _heightPix;
            set => _heightPix = value;
        }

        private static readonly Lazy<Frame> instanceHolder =
            new Lazy<Frame>(() => new Frame());

        public Frame()
        {
        }

        public static Frame Instance
        {
            get { return instanceHolder.Value; }
        }
    }
}