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

        private void tssiFrame_Click(object sender, EventArgs e)
        {
            
            pgSettings.SelectedObject = Settings.Frame.Instance;
        }

        private void tssiSwingSetting_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = Settings.Swing.Instance;
        }

        private void tssiNet_Click(object sender, EventArgs e)
        {
            pgSettings.SelectedObject = Settings.Net.Instance;
        }

        private void tsBSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
