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

        double _scale;
        public Drawer_Frames(Frames frames, double scale) {
            int i = 0;
            foreach (var element in frames.Map) {
                Dictionary_Frames.Add(i, element);
                i++;
            }
            _scale = scale;
            frame_width = (int)(frames.Map[0].Width * frames.Map[0].PixelWidth * _scale - 70 * _scale);
            frame_height = (int)(frames.Map[0].Height * frames.Map[0].PixelHeight * _scale);
            /*frame_width = (int)(frames.Map[0].Width * (frames.Map[0].PixelWidth * scale) - 40 * scale);
            frame_height = (int)(frames.Map[0].Height * (frames.Map[0].PixelHeight * scale) + 10 * scale);*/
        }
        public bool is_frame(int x,int y) {
            try
            {
                clMap sergey = _frames_array[x][y];
                return true;
            }
            catch {
                return false;
            }
            
        }

        public void Drawing(Graphics g, int width)
        {

            int k =0;
            for (k =0; k < width; k+=frame_width) { 
            }
            _frames_array = new clMap[k/ frame_width][];
            
            Point img_point = new Point(10, 10);
            int i = 0;
            int j = 0;
            for (i = 0; i < (k / frame_width); i++)
            {
                _frames_array[i] = new clMap[(Dictionary_Frames.Values.Count) / (k/frame_width) +1];
            }
            i = 0;
            j = 0;
            foreach (var frame in Dictionary_Frames.Values) {

                /*_frames_array[i][j] = frame;*/
                g.DrawImage(frame.pic, img_point);
                if (img_point.X + frame_width < width)
                {
                    _frames_array[i][j] = frame;
                    i++;
                    img_point.X += frame_width;
                    //_frames_array[i-1][j] = frame;
                }
                else
                {
                    _frames_array[i][j] = frame;
                    j++;
                    i = 0;
                    img_point.X = 10;
                    img_point.Y += frame_height;
                    
                }
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
                Frame_bmp = new Bitmap(_Map[index].Width * _Map[index].PixelWidth,
                _Map[index].Height * _Map[index].PixelWidth);
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

                    g.FillRectangle(b,   i * Map.PixelWidth,   j * (Map.PixelWidth), //drink
                        (int)(Map.PixelWidth - 2), (int)(Map.PixelHeight - 2));
                }
            Map.PixelWidth = old_pix.Width; //воооооооооооооттттт
            Map.PixelHeight = old_pix.Height;
        }
    }
}
