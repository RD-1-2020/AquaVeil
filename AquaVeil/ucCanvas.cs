using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaVeil
{
    public partial class ucCanvas : UserControl
    {

        public clMap Map;

        private Int32 _distX = 10;
        private Int32 _distY = 10;

        public ucCanvas()
        {
            InitializeComponent();
            Map = new clMap();
        }
        
        public void add_frame(String name_frame,int num_frame)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Image image = pictureBox1.Image;
            image.Crop(new Rectangle(0,0,Map.Width * Map.PixelWidth + 2* Map.Width,
                    Map.Hight * Map.PixelHight + 2 * Map.Hight));
            listView1.StateImageList.Images.Add(image);
            listView1.Items.Add(namecadr,num_cadr);
        }
        public void Drawing()
        {
            Graphics g = pictureBox1.CreateGraphics();

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
            Drawing();

            toolStripStatusLabel1.Text = "X=" + x.ToString() + " Y=" + y.ToString() + " xx = " + xx.ToString() + " yy = " + yy.ToString();
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
