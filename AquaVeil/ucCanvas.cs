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
        public Frames frames = new Frames();
        public List<clMap> clMapList = new List<clMap>();


        static private Int32 _distX = 10;
        static private Int32 _distY = 10;

        bool is_copy = false;
        
        public ucCanvas()
        {
            InitializeComponent();
            Map = new clMap();
            propertyGrid1.SelectedObject = Map;
        }

        public void Drawing()
        {
            if (Map == null)
                return;
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
            _main.CreateGraphics().Clear(_main.BackColor);
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
            Refresh();
            Map.CreateCanvas();
            Drawing();
        }
        //xernya?

        public void lb_savefr_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = pb_cadr_list.CreateGraphics();
                g.Clear(Color.Silver);
            if (!is_copy)
            {
                clMapList.Add(Map);
            }
            else {
                is_copy = false;
            }
            frames = new Frames();
            int i = 0;
            foreach (var element in clMapList)
            {
                frames[i] = element;
                i++;
            }
            new Drawer_Frames(frames,frames.image_scale).Drawing(g,pb_cadr_list.Width);
            Map = new clMap();
            propertyGrid1.SelectedObject = Map;
            Debug.WriteLine(clMapList.Count);
            Map.CreateCanvas();
            Drawing();
        }

        private void SB_frame_Scroll(object sender, ScrollEventArgs e)
        {
            if (frames.Map.Count== 0)
                return;
            Graphics g = pb_cadr_list.CreateGraphics();
            g.TranslateTransform(0,-SB_frame.Value);
            g.Clear(pb_cadr_list.BackColor);
            new Drawer_Frames(frames, frames.image_scale).Drawing(g, pb_cadr_list.Width);

        }

        private void pb_cadr_list_MouseClick(object sender, MouseEventArgs e)

        {
            if (clMapList.Count == 0)
                return;
            frames = new Frames();

            Graphics g1 = pb_cadr_list.CreateGraphics();
            g1.TranslateTransform(0, -SB_frame.Value);
            g1.Clear(pb_cadr_list.BackColor);
            int i = 0;
            foreach (var element in clMapList)
            {
                frames[i] = element;
                i++;
            }
            Graphics g = pb_cadr_list.CreateGraphics();
            g.TranslateTransform(0, -SB_frame.Value);
            var drawer = (new Drawer_Frames(frames, frames.image_scale));
            drawer.Drawing(g,pb_cadr_list.Width);
            int X = e.X;
            int Y = e.Y;
            int xx = (X)/ drawer.frame_wh;
            int yy = (Y + SB_frame.Value) / drawer.frame_hh;
            toolStripStatusLabel1.Text = "X=" + X.ToString() + " Y=" + Y.ToString() + " xx = " + xx.ToString() + " yy = " + yy.ToString();
            if (drawer.is_frame(xx, yy)) {
                Map = drawer.frames_array[xx][yy];
                _main.CreateGraphics().Clear(_main.BackColor);
                Drawing();
                is_copy = true;
            }
            propertyGrid1.SelectedObject = Map;
            
        }
    }
}
