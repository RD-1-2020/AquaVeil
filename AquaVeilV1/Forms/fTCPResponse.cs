using System;
using System.Windows.Forms;
using AquaVeilV1.DataSenders;

namespace AquaVeilV1.Forms
{
    public partial class fTCPResponse : Form
    {
        public fTCPResponse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpDataSender tcpDataSender = new TcpDataSender();

            tcpDataSender.SendData(textBox1.Text);
        }
    }
}
