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
    public class Drawer_Frames {

        private Dictionary<int, clMap> Dictionary_Frames = new Dictionary<int, clMap>();


        private clMap[][] _frames_array;
        
        public clMap[][] frames_array {
            get {
                return _frames_array;
            }
        }

        private int frame_width;

        public int frame_wh
        {
            get {
                return frame_width;
            }
        }
        private int frame_height;

        public int frame_hh
        {
            get
            {
                return frame_height;
            }
        }


        public Drawer_Frames(Frames frames, double scale) {
            int i = 0;
            foreach (var element in frames.Map) {
                Dictionary_Frames.Add(i, element);
                i++;
            }
            frame_width = (int)(frames.Map[0].Width * (frames.Map[0].PixelWidth * scale) - 40 * scale);
            frame_height = (int)(frames.Map[0].Height * (frames.Map[0].PixelHeight * scale) + 10 * scale);
        }


        public void Drawing(Graphics g, int width)
        {
            Point img_point = new Point(1, 1);
            int i = 0;
            int j = 0;
            foreach (var frame in Dictionary_Frames.Values) {
                g.DrawImage(frame.pic, img_point);
                if (img_point.X + frame_width < width)
                {
                    i++;
                    img_point.X += frame_width;
                }
                else
                {
                    j++;
                    i = 0;
                    img_point.X = 0;
                    img_point.Y += frame_height;
                }
                //frames_array[i][j] = frame;
            }
        }
        
    }
    public class Frames
    {
        //Создаём лист мапов для инициализации индексатора
        private List <clMap> _Map = new List<clMap>();
        private Bitmap Frame_bmp;
        public List<clMap> Map
        {
            get {
                return _Map;
            }
        }
        private Int32 _distX;
        private Int32 _distY;

        private Size old_pix;

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
                _Map[index].PixelHeight = (int)((double)_Map[index].PixelHeight * _image_scale);
                _Map[index].PixelWidth = (int)((double)_Map[index].PixelWidth * _image_scale);
                Frame_bmp = new Bitmap(_distX + _Map[index].Width * _Map[index].PixelWidth,
                _distY + _Map[index].Height * _Map[index].PixelWidth);
                in_bmp_draw(ref Frame_bmp, _Map[index]);
                _Map[index].pic = Frame_bmp;
            }
        }

        private void in_bmp_draw(ref Bitmap bmp, clMap Map) { //как поправить

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

                    g.FillRectangle(b, _distX + i * Map.PixelWidth, _distY + j * (Map.PixelWidth), 
                        (int)(Map.PixelWidth - 2*_image_scale), (int)(Map.PixelHeight - 2));
                }
            Map.PixelWidth = old_pix.Width; //вооооооооооооотттттт
            Map.PixelHeight = old_pix.Height;
        }
    }
}
