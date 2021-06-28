using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeilV1
{
    public class Settings
    {
        /// <summary>
        /// Singleton Pattern
        /// </summary>
        public class Frame
        {
            static private Int32 _width =140;
            static private Int32 _height = 100;

            /// <summary>
            /// Ширина кадра
            /// </summary>
            [Category("Поле")]
            [DisplayName("Длинна")]
            public static int Width
            {
                get => _width;
                set => _width = value;
            }

            /// <summary>
            /// Высота кадра
            /// </summary>
            [Category("Поле")]
            [DisplayName("Высота")]
            public static int Height
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
            public static int WidthPix
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
            public static int HeightPix
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

        public sealed class Swing
        {
            private static readonly Lazy<Swing> instanceHolder =
                new Lazy<Swing>(() => new Swing());

            public Swing()
            {
            }

            public static Swing Instance
            {
                get { return instanceHolder.Value; }
            }

            private static Int32 _pixSpacing = 1;
            private static Int32 _pixPeriod = 1;
            private static Int32 _pixMinAmplitude = 100;

            /// <summary>
            /// Коэффициент расстояния между пикселями
            /// </summary>
            [Category("Подстройка")]
            [DisplayName("Коэффициент расстояния между пикселями")]
            public static int PixSpacing
            {
                get => _pixSpacing;
                set => _pixSpacing = value;
            }

            /// <summary>
            /// Коффициент Периода прохождения пикселем полного цикла
            ///</summary>
            [Category("Подстройка")]
            [DisplayName("Коффициент Периода прохождения пикселем полного цикла")]
            public static int PixPeriod
            {
                get => _pixPeriod;
                set => _pixPeriod = value;
            }

            /// <summary>
            /// Минимальная амплитуда отклонения
            /// </summary>
            [Category("Подстройка")]
            [DisplayName("Минимальная амплитуда отклонения")]
            public static int PixMinAmplitude
            {
                get => _pixMinAmplitude;
                set => _pixMinAmplitude = value;
            }
        }
    }
}
