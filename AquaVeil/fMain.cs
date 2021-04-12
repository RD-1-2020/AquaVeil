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
            ucCanvas.add_frame("drink",1);
        }
    }
}
