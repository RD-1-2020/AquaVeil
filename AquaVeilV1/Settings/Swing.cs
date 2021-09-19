using System;
using System.ComponentModel;

namespace AquaVeilV1.Settings
{
    /// <summary>
    /// Singleton Pattern
    /// Настройки качелей
    /// </summary>
    public class Swing
    {
        private static readonly Lazy<Swing> instanceHolder =
            new Lazy<Swing>(() => new Swing());

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
        public int PixSpacing
        {
            get => _pixSpacing;
            set => _pixSpacing = value;
        }

        /// <summary>
        /// Коффициент Периода прохождения пикселем полного цикла
        ///</summary>
        [Category("Подстройка")]
        [DisplayName("Коффициент Периода прохождения пикселем полного цикла")]
        public int PixPeriod
        {
            get => _pixPeriod;
            set => _pixPeriod = value;
        }

        /// <summary>
        /// Минимальная амплитуда отклонения
        /// </summary>
        [Category("Подстройка")]
        [DisplayName("Минимальная амплитуда отклонения")]
        public int PixMinAmplitude
        {
            get => _pixMinAmplitude;
            set => _pixMinAmplitude = value;
        }
    }
}