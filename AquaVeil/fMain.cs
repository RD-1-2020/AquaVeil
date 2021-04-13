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
            //propertyGrid1.SelectedObject = clMap;
        }

        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            Refresh(); //Блин как сделать то
        }
    }
}
