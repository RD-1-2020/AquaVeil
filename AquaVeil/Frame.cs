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
    public class Frames
    {
        //Создаём лист мапов для инициализации индексатора
        private List <clMap> _Map = new List<clMap>();
        private Bitmap Frame_bmp;

        private Int32 _distX;
        private Int32 _distY;

        private double _image_scale = 0.5;
        public double image_scale
        {
            get {
                return _image_scale;
            }
            set {
                _image_scale = value;
            }
        }

        public Frames(Int32 distX, Int32 distY) {
            _distX = (int)(distX * _image_scale);
            _distY = (int)(distY * _image_scale);
        }

        private void in_bmp_draw(ref Bitmap bmp, clMap Map) { //как поправить

            Graphics g = Graphics.FromImage(bmp);

            SolidBrush bb = new SolidBrush(Map.ColorPenBackground);
            SolidBrush bf = new SolidBrush(Map.ColorPenForeground);
            SolidBrush b;

            Pen pb = new Pen(bb);
            Pen pf = new Pen(bf);

            for (int i = 0; i < Map.Width; i++)
                for (int j = 0; j < Map.Width; j++)
                {
                    if (Map.MapCanvas[i][j] == 0)
                        b = bf;
                    else
                        b = bb;

                    g.FillRectangle(b, _distX + i * Map.PixelWidth, _distY + j * (Map.PixelWidth), 
                        (int)(Map.PixelWidth - 2*_image_scale), (int)(Map.PixelHeight - 2));
                }
            Map.PixelWidth = 15; //вооооооооооооотттттт
            Map.PixelHeight = 15;

        }
        public clMap this[int index] {
            get {
                return _Map[index];
            } set {
                _Map.Add(value);
                _Map[index].PixelHeight = (int)((double)_Map[index].PixelHeight * _image_scale);
                _Map[index].PixelWidth = (int)((double)_Map[index].PixelWidth * _image_scale);
                Frame_bmp = new Bitmap(_distX + _Map[index].Width * _Map[index].PixelWidth,
                _distY + _Map[index].Height * _Map[index].PixelWidth);
                in_bmp_draw(ref Frame_bmp,_Map[index]);
                _Map[index].pic = Frame_bmp;
            }
        }
    }
}
