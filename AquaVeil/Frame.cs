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


        private clMap[] _frames_array;
        
        public clMap[] frames_array {
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

        double _scale;
        public Drawer_Frames(Frames frames, double scale) {
            int i = 0;
            foreach (var element in frames.Map) {
                Dictionary_Frames.Add(i, element);
                i++;
            }
            _scale = scale;
            frame_width = (int)(frames.Map[0].Width * frames.Map[0].PixelWidth * _scale + 10);
            /*frame_width = (int)(frames.Map[0].Width * (frames.Map[0].PixelWidth * scale) - 40 * scale);
            frame_height = (int)(frames.Map[0].Height * (frames.Map[0].PixelHeight * scale) + 10 * scale);*/
        }
        public bool is_frame(int x) {
            try
            {
                clMap sergey = _frames_array[x];
                return true;
            }
            catch {
                return false;
            }
            
        }

        public void Drawing(Graphics g, int width)
        {
            g.Clear(Color.Gray);
            _frames_array = new clMap[Dictionary_Frames.Count];
            int xx = 10;
            int i = 0;
            foreach (var frame in Dictionary_Frames.Values) {
                g.DrawImage(frame.pic, new Point(xx,10));
                _frames_array[i] = frame;
                i++;
                xx += (frame.pic.Width + 10);
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

                    g.FillRectangle(b,  (int) (i * Map.PixelWidth*image_scale), (int)(j * (Map.PixelWidth) * image_scale), //drink
                        (int)(Map.PixelWidth - 2), (int)(Map.PixelHeight - 2));
                }
            Map.PixelWidth = old_pix.Width; //воооооооооооооттттт
            Map.PixelHeight = old_pix.Height;
        }
    }
}
