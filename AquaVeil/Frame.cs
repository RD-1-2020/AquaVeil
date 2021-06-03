using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVeil;

namespace AquaVeil
{
    //Класс для массива кадров
    public class Frames
    {
        //Создаём лист мапов для инициализации индексатора
        private List <clMap> _Map = new List<clMap>();
        // Графика кадра
        private Bitmap Frame_bmp;

        public List<clMap> Map
        {
            get {
                return _Map;
            }
        }

        private Size old_pix;
        // Масштаб картинки
        private double _image_scale = 0.1;

        public double image_scale
        {
            get {
                return _image_scale;
            }
            set {
                _image_scale = value;
            }
        }

        // Индексатор по мапам, при добавлении нового для кадра создаётся графика
        public clMap this[int index]
        {
            get
            {
                return _Map[index];
            }
            set
            {
                _Map.Add(value);
                old_pix = new Size(_Map[index].PixelWidth, _Map[index].PixelHeight);
                Frame_bmp = new Bitmap((int)((double)_Map[index].Width * _Map[index].PixelWidth*image_scale),
                (int)((double)_Map[index].Height * _Map[index].PixelWidth*image_scale));
                in_bmp_draw(ref Frame_bmp, _Map[index]);
                _Map[index].pic = Frame_bmp;
            }
        }

        // Фукнция для превращения кадра в виде массива в битмап
        private void in_bmp_draw(ref Bitmap bmp, clMap Map) {

            Graphics g = Graphics.FromImage(bmp);

            SolidBrush bb = new SolidBrush(Map.ColorPenBackground);
            SolidBrush bf = new SolidBrush(Map.ColorPenForeground);
            SolidBrush b;

            Pen pb = new Pen(bb);
            Pen pf = new Pen(bf);

            for (int i = 0; i < Map.Width; i++)
                for (int j = 0; j < Map.Height; j++)
                {
                    if (Map.MapCanvas[i][j] == 0)
                        b = bf;
                    else
                        b = bb;
                    // TODO: Что-то здесь не то, глянуть
                    g.FillRectangle(b,  (int) (i * Map.PixelWidth*image_scale), (int)(j * (Map.PixelWidth) * image_scale),
                        (int)(Map.PixelWidth - 2), (int)(Map.PixelHeight - 2));
                }
            Map.PixelWidth = old_pix.Width;
            Map.PixelHeight = old_pix.Height;
        }
    }
}
