using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace AquaVeil
{
    public partial class ucCanvas : UserControl
    {

        public clMap Map;
        public Frames frames = new Frames(_distX, _distY);
        public List<clMap> clMapList = new List<clMap>();


        static private Int32 _distX = 10;
        static private Int32 _distY = 10;
        
        public ucCanvas()
        {
            InitializeComponent();
            Map = new clMap();
        }

        public void Drawing()
        {
            Graphics g = this._main.CreateGraphics();

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
                 
                    g.FillRectangle(b, _distX+i* Map.PixelWidth, _distY+j*(Map.PixelWidth), Map.PixelWidth-2, Map.PixelHeight-2);
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
            Int32 yy = (y - _distY) / Map.PixelHeight;

            Map.InvertPixel(xx, yy);
            Drawing();

            toolStripStatusLabel1.Text = "X=" + x.ToString() + " Y=" + y.ToString() + " xx = " + xx.ToString() + " yy = " + yy.ToString();
        }

        private void lb_clear_Click(object sender, EventArgs e)
        {
            Map.CreateCanvas();
            Drawing();
        }

        private void lb_savefr_Click(object sender, EventArgs e)
        {
            Graphics g = pb_cadr_list.CreateGraphics();
            g.Clear(Color.Gray);
            clMapList.Add(Map);
            frames = new Frames(_distX, _distY);
            Point img_point = new Point(1, 1);
            for (int i = 0; i < clMapList.Count; i++)
            {
                frames[i] = clMapList[i];
                g.DrawImage(frames[i].pic, img_point);
                img_point.X += (int)(_distX + Map.Width * Map.PixelWidth * frames.image_scale);
            }
            Map = new clMap();
            Debug.WriteLine(clMapList.Count);
            Map.CreateCanvas();
            Drawing();
        }
    }
}
