using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeil
{
    public class clMap
    {
        private Int32 _Hight = 10;
        private Int32 _Width = 10;

        private Int32 _PixelHight = 15;
        private Int32 _PixelWidth = 15;

        private Color _ColorPenForeground = Color.Red;
        private Color _ColorPenBackground = Color.White;


        private Int32[][] _MapCanvas;

        /// <summary>
        /// Высота поля
        /// </summary>
        [DisplayName("Высота")]
        [Category("Поле")]
        [Description("Высота поля")]
        public Int32 Hight
        {
            set { _Hight = value; }
            get { return _Hight; }
        }

        /// <summary>
        /// Ширина поля
        /// </summary>
        [DisplayName("Ширина")]
        [Category("Поле")]
        [Description("Ширина поля")]
        public Int32 Width
        {
            set { _Width = value; }
            get { return _Width; }
        }



        /// <summary>
        /// Высота пикселя
        /// </summary>
        [DisplayName("Высота пикселя")]
        [Category("Пиксель")]
        [Description("Ширина поля")]
        public Int32 PixelHight
        {
            set { _PixelHight = value; }
            get { return _PixelHight; }
        }


        /// <summary>
        /// Ширина пикселя
        /// </summary>
        [DisplayName("Ширина пикселя")]
        [Category("Пиксель")]
        [Description("Ширина поля")]
        public Int32 PixelWidth
        {
            set { _PixelWidth = value; }
            get { return _PixelWidth; }
        }


        /// <summary>
        /// Ширина пикселя
        /// </summary>
        [DisplayName("Цвет пикселя незакрашенного")]
        [Category("Пиксель")]
        [Description("Цвет пикселя незакрашенного")]
        public Color ColorPenBackground
        {
            set { _ColorPenBackground = value; }
            get { return _ColorPenBackground; }
        }


        /// <summary>
        /// "Цвет пикселя закрашенного
        /// </summary>
        [DisplayName("Цвет пикселя закрашенного")]
        [Category("Пиксель")]
        [Description("Цвет пикселя закрашенного")]
        public Color ColorPenForeground
        {
            set { _ColorPenForeground = value; }
            get { return _ColorPenForeground; }
        }


        public Int32[][] MapCanvas
        {
            set { _MapCanvas = value; }
            get { return _MapCanvas; }
        }


        public clMap()
        {
            _MapCanvas = new Int32[_Width][];
            for (int i = 0; i < _Width; i++)
                _MapCanvas[i] = new Int32[_Hight];


            for (int i = 0; i < _Width; i++)
                for (int j = 0; j < _Hight; j++)
                    _MapCanvas[i][j] = 0;
        }



        public void CreateCanvas()
        {
            _MapCanvas = new Int32[_Width][];
            for (int i = 0; i < _Width; i++)
                _MapCanvas[i] = new Int32[_Hight];


            for (int i = 0; i < _Width; i++)
                for (int j = 0; j < _Hight; j++)
                    _MapCanvas[i][j] = 0;
        }


        public Boolean InvertPixel(Int32 x, Int32 y)
        {
            if (x > Width)
                return false;

            if (x > Hight)
                return false;

            if (MapCanvas[x][y] == 0)
                MapCanvas[x][y] = 1;
            else
                MapCanvas[x][y] = 0;

            return true;
        }

    }
}
