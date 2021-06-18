using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaVeilV1
{
    public partial class fSettingsRedact : Form
    {
        public fSettingsRedact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Width = Convert.ToInt32(tbWidth.Text);
                Settings.Height = Convert.ToInt32(tbHeight.Text);
            }
            catch (Exception) { }
            this.Close();
        }
    }
}
