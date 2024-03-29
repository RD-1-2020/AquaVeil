﻿using AquaVeilV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVeilV1.Utils;

namespace AquaVeilV1
{
    public class clMap
    {
        private Int32 _Height = Settings.Frame.Instance.Height;
        private Int32 _Width = Settings.Frame.Instance.Width;

        private Int32 _PixelHeight = Settings.Frame.Instance.HeightPix;
        private Int32 _PixelWidth = Settings.Frame.Instance.WidthPix;

        private Color _ColorPenForeground = Color.Red;
        private Color _ColorPenBackground = Color.White;

        private Color[] _ColumnColor;

        private Int32 _WidthMargin = 0;
        private Int32 _HeightMargin = 0;

        private Int32[][] _MapCanvas;

        /// <summary>
        /// Высота поля
        /// </summary>
        public Int32 Height
        {
            set { _Height = value; }
            get { return _Height; }
        }

        /// <summary>
        /// Ширина поля
        /// </summary>
        public Int32 Width
        {
            set { _Width = value; }
            get { return _Width; }
        }



        /// <summary>
        /// Высота пикселя
        /// </summary>
        public Int32 PixelHeight
        {
            set { _PixelHeight = value; }
            get { return _PixelHeight; }
        }


        /// <summary>
        /// Ширина пикселя
        /// </summary>
        public Int32 PixelWidth
        {
            set { _PixelWidth = value; }
            get { return _PixelWidth; }
        }


        /// <summary>
        /// Ширина пикселя
        /// </summary>
        public Color ColorPenBackground
        {
            set { _ColorPenBackground = value; }
            get { return _ColorPenBackground; }
        }


        /// <summary>
        /// "Цвет пикселя закрашенного
        /// </summary>
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
        public void printFramesToFiles(int fileNum, string Path)
        {
            // 1 файл - Frame{fileNum}.txt
            printToFileTxt(fileNum);

            // 2 файл - Frame{fileNum}Color.txt временно упрощён
            //PrintFramesColor(fileNum, Path);
        }

        private void PrintFrames(int fileNum, string Path)
        {
            string fileText = "";
            string fileName = $@"Frame{fileNum}.fav";

            Int32[][] mappingCanvas = getMappingCanvas();

            uint tempbyte = 0;
            uint tempbit = 0;

            int countX = (int)Math.Ceiling(Width / 8.0);
            Byte[,] bMap = new Byte[countX, Height];

            for (int j = 0; j < Height; j++)
            for (int i = 0; i < countX; i++)
                bMap[i, j] = 0;


            for (int j = 0; j < Height; j++)
            for (int i = 0; i < countX; i++)
            {
                tempbyte = 0;
                for (int ii = 0; (ii < 8) && ((i * 8 + ii) < Width); ii++)
                {
                    tempbit = ((UInt32)mappingCanvas[i * 8 + ii][j]) << (7 - ii);
                    tempbyte = tempbyte | tempbit;
                }
                bMap[i, j] = (byte)tempbyte;
            }


            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int j = 0; j < Height; j++)
                for (int i = 0; i < countX; i++)
                {
                    writer.Write(bMap[i, j]);
                }



            }
        }

        public void printToFileTxt(int fileNum)
        {
            string fileText = "";
            string fileName = $@"Frame{fileNum}.txt";

            Int32[][] mappingCanvas = getMappingCanvas();

            uint tempbyte = 0;
            uint tempbit = 0;

            int countX = (int)Math.Ceiling(Width / 8.0);
            Byte[,] bMap = new Byte[countX, Height];

            for (int j = 0; j < Height; j++)
            for (int i = 0; i < countX; i++)
                bMap[i, j] = 0;


            for (int j = 0; j < Height; j++)
            for (int i = 0; i < countX; i++)
            {
                tempbyte = 0;
                for (int ii = 0; (ii < 8) && ((i * 8 + ii) < Width); ii++)
                {
                    tempbit = ((UInt32)mappingCanvas[i * 8 + ii][j]) << (7 - ii);
                        tempbyte = tempbyte | tempbit;
                }
                bMap[i, j] = (byte)tempbyte;
            }


            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                sw.Write("{");

                for (int j = 0; j < Height; j++)
                {
                    sw.Write("{");

                    for (int i = 0; i < countX - 1; i++)
                        sw.Write("0x" + bMap[i, j].ToString("X2") + ", ");
                    sw.Write("0x" + bMap[countX - 1, j].ToString("X2"));
                    sw.Write("},");
                    sw.WriteLine();
                }
                sw.Write("}");
            }
        }

        public int[][] getMappingCanvas()
        {
            Settings.InjectorMap injectorMap = new Settings.InjectorMap();

            injectorMap.initMapping();

            int[][] mappingCanvas = new int[Settings.Frame.Instance.Width][];

            for (int i = 0; i < MapCanvas.Length; i++)
            {
                uint mappingAddres = injectorMap._map[i]._addres;

                mappingCanvas[i] = MapCanvas[mappingAddres - 1];
            }

            return mappingCanvas;
        }


        // На данный момент не используется
        private void PrintFramesColor(int fileNum, string Path)
        {
            string fileText = "";
            string fileName = $"Frame{fileNum}Color.data";

            // for (var i = 0; i < Width; i++)
            //     {
            //
            //         fileText += Convert.ToString(ColumnColor[i].R, 16) + (ColumnColor[i].R == 0 ? "0" : "");
            //         fileText += Convert.ToString(ColumnColor[i].G, 16) + (ColumnColor[i].G == 0 ? "0" : "");
            //         fileText += Convert.ToString(ColumnColor[i].B, 16) + (ColumnColor[i].B == 0 ? "0" : "");
            //         fileText += "\n";
            //     }

            fileText += Convert.ToString(ColumnColor[0].R, 16) + (ColumnColor[0].R == 0 ? "0" : "");
            fileText += Convert.ToString(ColumnColor[0].G, 16) + (ColumnColor[0].G == 0 ? "0" : "");
            fileText += Convert.ToString(ColumnColor[0].B, 16) + (ColumnColor[0].B == 0 ? "0" : "");
            fileText += "\n";

            using (FileStream fs = new FileStream($@"{Path}\{fileName}", FileMode.OpenOrCreate))
            {
                using (BinaryWriter fileFrame = new BinaryWriter(fs, Encoding.ASCII))
                {
                    fileFrame.Write(fileText);
                }
            }
        }

        public void InsertBmp(Bitmap importBmp)
        {
            importBmp.ToMonochrome();

            if (importBmp.Width > Width)
            {
                importBmp = new Bitmap(importBmp, new Size(Width, (int)((1.0 * importBmp.Height / importBmp.Width) * Height)));
            }

            if (importBmp.Height > Height)
            {
                importBmp = new Bitmap(importBmp, new Size((int)((1.0*importBmp.Height / importBmp.Width) * Width), Height));
            }

            for (int x = 0; x < importBmp.Width; x++)
            {
                for (int y = 0; y < importBmp.Height; y++)
                {
                    if (importBmp.GetPixel(x, y).B == 255)
                    {
                        InvertPixel(x, y);
                    }
                }
            }
        }
    }
}
