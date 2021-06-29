using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AquaVeilV1
{
    public class Settings
    {
        /// <summary>
        /// Singleton Pattern
        /// Настройки поля и clMap
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

        /// <summary>
        /// Singleton Pattern
        /// Настройки качелей
        /// </summary>
        public class Swing
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

        /// <summary>
        /// Singleton Pattern
        /// Настройки сети
        /// </summary>
        public class Net
        {
            private static string _swingIp = "127.0.0.1";
            private static string _port = "8888";

            [Category("Качели")]
            [DisplayName("IP-Адрес")]
            public string SwingIp
            {
                get => _swingIp;
                set => _swingIp = value;
            }

            [Category("Качели")]
            [DisplayName("Порт")]
            public string Port
            {
                get => _port;
                set => _port = value;
            }

            private static readonly Lazy<Net> instanceHolder =
                new Lazy<Net>(() => new Net());

            public Net()
            {
            }

            public static Net Instance
            {
                get { return instanceHolder.Value; }
            }

            /*public class IPAddressEditor : UITypeEditor
            {
                private Form IPAddressEditorForm;

                /// <summary>
                /// Реализация метода редактирования
                /// </summary>
                public override Object EditValue(ITypeDescriptorContext context, IServiceProvider provider, Object value)
                {
                    if((context != null) && (provider != null)) 
                    {
                        IWindowsFormsEditorService svc =
                            (IWindowsFormsEditorService)
                            provider.GetService(typeof(IWindowsFormsEditorService));

                        if(svc!= null) 
                        {
                            // using (IPAddressEditorForm ipfrm = new IPAddressEditorForm((IPAddress) value))
                            // {
                            //     if (svc.ShowDialog(ipfrm) == DialogResult.OK)
                            //     {
                            //         value = ipfrm.IP;
                            //     }
                            // }
                        }
                    }

                    return base.EditValue(context, provider, value);
                }

                /// <summary>
                /// Возвращаем стиль редактора - модальное окно
                /// </summary>
                public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
                {
                    if (context != null)
                    {
                        return UITypeEditorEditStyle.Modal;
                    }
                    else
                    {
                        return base.GetEditStyle(context);
                    }
                }
            }*/
        }
    }
}
