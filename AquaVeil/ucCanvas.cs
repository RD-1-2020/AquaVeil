using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AquaVeil
{
    public partial class ucCanvas : UserControl
    {

        public clMap Map;

        private Int32 _distX = 10;
        private Int32 _distY = 10;
        public ImageList frame_list = new ImageList();
        public ucCanvas()
        {
            InitializeComponent();
            Map = new clMap();
        }
        
        public void add_frame(String name_frame,int num_frame)
        {
            // Короче хер его знает, можно попробовать перерисовывать в лист вью, я просто так ебал
            // можно сделать эрейлист кадров(2), а кадры сделать классами (1)
            // ну а у кадров сделать их положение и потом хуярить их в листвью(3) (можно и пб)
            Graphics g = pb_main.CreateGraphics();
            Image image = pb_main.Image;
            image.Crop(new Rectangle(0,0,Map.Width * Map.PixelWidth + 2* Map.Width,
            Map.Hight * Map.PixelHight + 2 * Map.Hight));
            frame_list.Images.Add(name_frame,image);
            Debug.WriteLine(frame_list.Images.Count);
            listView1.SmallImageList = frame_list;
            listView1.Items.Add(name_frame, num_frame);
        }
        public void Drawing()
        {
            Bitmap bmp = new Bitmap(pb_main.Width,pb_main.Height);
            Graphics g = Graphics.FromImage(bmp as Image); // Тут ес чо поправить

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
                 
                    g.FillRectangle(b, _distX+i* Map.PixelWidth, _distY+j*(Map.PixelWidth)
                        , Map.PixelWidth-2, Map.PixelHight-2);
                }
            pb_main.Image = bmp;
        }
        /// <summary>
        /// Перерисовка одного пикселя
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Redraw_pixel(int x,int y) {
            SolidBrush b;
            Graphics g = pictureBox1.CreateGraphics();
            if (Map.MapCanvas[x][y] == 0)
                b = new SolidBrush(Map.ColorPenForeground);
            else
                b = new SolidBrush(Map.ColorPenBackground);
                g.FillRectangle(b, _distX + x * Map.PixelWidth, _distY + y * (Map.PixelWidth), Map.PixelWidth - 2, Map.PixelHight - 2);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Drawing();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Int32 x = e.X;
            Int32 y = e.Y;

            Int32 xx = (x - _distX) / Map.PixelWidth;
            Int32 yy = (y - _distY) / Map.PixelHight;

            Map.InvertPixel(xx, yy);
            //Redraw_pixel(xx,yy); Предложение (так как при больших размерах лагает и не оптимально)
            Drawing();

            toolStripStatusLabel1.Text = "X=" + x.ToString() + " Y=" + y.ToString() + " xx = " + xx.ToString() + " yy = " + yy.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Int32 x = e.X;
            Int32 y = e.Y;

            Int32 xx = (x - _distX) / Map.PixelWidth;
            Int32 yy = (y - _distY) / Map.PixelHight;

            Map.InvertPixel(xx, yy);
            Redraw_pixel(xx, yy);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Map = new clMap();
            Drawing();
        }
    }
    static class ext {
        public static Image Crop(this Image image, Rectangle selection)
        {
            Bitmap bmp = image as Bitmap;
            if (bmp == null)
                throw new ArgumentException("No valid bitmap");
            // Crop the image:
            Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);
            image.Dispose();
            return cropBmp;
        }
    }
}
