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
    public partial class fTCPResponse : Form
    {
        public fTCPResponse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSender dataSender = new DataSender();

            dataSender.SendData(textBox1.Text);
        }
    }
}
