using AquaVeilV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeilV1
{
    public class clMap
    {
        private Int32 _Height = Settings.Height;
        private Int32 _Width = Settings.Width;

        private Int32 _PixelHeight = Settings.HeightPix;
        private Int32 _PixelWidth = Settings.WidthPix;

        private Color _ColorPenForeground = Color.Red;
        private Color _ColorPenBackground = Color.White;

        private Color[] _ColumnColor;

        private Int32 _WidthMargin = 2;
        private Int32 _HeightMargin = 0;

        private Int32[][] _MapCanvas;

        /// <summary>
        /// Высота поля
        /// </summary>
        [DisplayName("Высота")]
        [Category("Поле")]
        [Description("Высота поля")]
        public Int32 Height
        {
            set { _Height = value; }
            get { return _Height; }
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
        public Int32 PixelHeight
        {
            set { _PixelHeight = value; }
            get { return _PixelHeight; }
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

        /// <summary>
        /// Цвет каждого столбца
        /// </summary>
        public Color[] ColumnColor { 
            get => _ColumnColor; 
            set => _ColumnColor = value; 
        }

        /// <summary>
        /// Растояние между пикселями в длинну
        /// </summary>
        public int WidthMargin { 
            get => _WidthMargin; 
            set => _WidthMargin = value;
        }

        /// <summary>
        /// Растояние между пикселями в ширину
        /// </summary>
        public int HeightMargin {
            get => _HeightMargin; 
            set => _HeightMargin = value; 
        }

        public clMap()
        {
            _MapCanvas = new Int32[_Width][];
            for (int i = 0; i < _Width; i++)
                _MapCanvas[i] = new Int32[_Height];


            for (int i = 0; i < _Width; i++)
                for (int j = 0; j < _Height; j++)
                    _MapCanvas[i][j] = 0;

            initColor();
        }

        public void initColor() {
            ColumnColor = new Color[_Width];
            for (int i = 0; i < _Width; i++)
            {
                ColumnColor[i] = this.ColorPenForeground;
            }
        }

        public void CreateCanvas()
        {
            _MapCanvas = new Int32[_Width][];
            for (int i = 0; i < _Width; i++)
                _MapCanvas[i] = new Int32[_Height];

            for (int i = 0; i < _Width; i++)
                for (int j = 0; j < _Height; j++)
                    _MapCanvas[i][j] = 0;
        }

        public Boolean InvertPixel(Int32 x, Int32 y)
        {
            if (x >= Width || x<0)
                return false;

            if (y >= Height || y<0)
                return false;

            if (MapCanvas[x][y] == 0)
                MapCanvas[x][y] = 1;
            else
                MapCanvas[x][y] = 0;

            return true;
        }

        /// <summary>
        /// Функция для создания картинки по MapCanvas
        /// </summary>
        /// <returns>Картинка</returns>
        public Bitmap getBitmap() {
            Bitmap frameBitmap = new Bitmap(_Width * _PixelWidth,_Height * _PixelHeight);

            Graphics g = Graphics.FromImage(frameBitmap);

            SolidBrush bf = new SolidBrush(ColorPenBackground);
            SolidBrush b;

            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                {
                    if (MapCanvas[i][j] == 0)
                        b = new SolidBrush(ColumnColor[i]);
                    else
                        b = bf;
                    g.FillRectangle(b, i * PixelWidth, j * PixelHeight, PixelWidth - WidthMargin, PixelHeight - HeightMargin);
                }
            return frameBitmap;
        }

        public bool changeColumnColor(Color newColor, int colorIndex)
        {
            if (colorIndex >= Width || colorIndex < 0)
                return false;
            ColumnColor[colorIndex] = newColor;
            return true;
        }

        /// <summary>
        /// Цветовая панель по _ColumnColor
        /// </summary>
        /// <returns>Каринка для работы с цветовой панелью</returns>
        public Bitmap getColorsBitmap() {
            Bitmap frameBitmap = new Bitmap(_Width * _PixelWidth, _Height * _PixelHeight);

            Graphics g = Graphics.FromImage(frameBitmap);

            SolidBrush b;

            for (int i = 0; i < Width; i++)
            {
                b = new SolidBrush(ColumnColor[i]);
                g.FillRectangle(b, i * PixelWidth, 0, PixelWidth - WidthMargin, PixelHeight - HeightMargin);
            }
            return frameBitmap;
        }

        /// <summary>
        /// Функция превращения clMap в файлы
        /// 1 файл - Frame{fileNum}.txt Хранит настройки кадра и сам кадр в виде 
        /// двумерного массива
        /// 2 файл - Frame{fileNum}Color.txt Хранит цвета кадра по столбцам
        /// </summary>
        /// <param name="fileNum">Часть имени файла</param>
        /// <param name="Path">Путь где сохранять файл</param>
        public void printToFiles(int fileNum,string Path) {
            // 1 файл - Frame{fileNum}.txt
            string fileText = "";
            string fileName = @"Frame" + fileNum + ".txt";

            fileText += Convert.ToString(Settings.Width, 16) + "\n";
            fileText += Convert.ToString(Settings.Height, 16) + "\n";


            for (int i = 0; i <MapCanvas[i].Length; i++)
            {
                for (int j = 0; j < MapCanvas.Length; j++)
                {
                    fileText += MapCanvas[j][i];
                }
                fileText += "\n";
            }

            using (StreamWriter FileFrame = new StreamWriter(Path + @"\" + fileName, false, System.Text.Encoding.Default))
            {
                FileFrame.Write(fileText);
                fileText = "";
            }

            // 2 файл - Frame{fileNum}Color.txt 
            fileName = "Frame" + fileNum + "Color.txt";

            for (int i = 0; i < Width; i++)
            {

                fileText += Convert.ToString(ColumnColor[i].R, 16) + (ColumnColor[i].R == 0 ? "0" : "");
                fileText += Convert.ToString(ColumnColor[i].G, 16) + (ColumnColor[i].G == 0 ? "0" : "");
                fileText += Convert.ToString(ColumnColor[i].B, 16) + (ColumnColor[i].B == 0 ? "0" : "");
                fileText += "\n";
            }

            using (StreamWriter FileFrame = new StreamWriter(Path + @"\" + fileName, false, System.Text.Encoding.Default))
            {
                FileFrame.Write(fileText);
            }
        }
    }
}
