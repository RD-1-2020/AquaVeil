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
    public partial class fMain : Form
    {
        public PictureBox pb = new PictureBox();
        public fMain()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = ucCanvas.Map;
        }

        private void ucCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_frame("drink",1);
        }
        public void add_frame(String name_frame, int num_frame)
        {

            Graphics g = ucCanvas.pictureBox1.CreateGraphics();
            ucCanvas.pictureBox1.Invalidate();
            Image image = ucCanvas.pictureBox1.Image;
            image.Crop(new Rectangle(0, 0, ucCanvas.Map.Width * ucCanvas.Map.PixelWidth + 2 * ucCanvas.Map.Width,
                    ucCanvas.Map.Hight * ucCanvas.Map.PixelHight + 2 * ucCanvas.Map.Hight));
            ucCanvas.listView1.StateImageList.Images.Add(image);
            ucCanvas.listView1.Items.Add(name_frame, num_frame);
        }
    }
}
