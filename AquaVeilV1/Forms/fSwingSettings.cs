using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AquaVeilV1.DataSenders;
using AquaVeilV1.Settings;

namespace AquaVeilV1.Forms
{
    public partial class fSwingSettings : Form
    {
        private ComDataSender comDataSender = new ComDataSender();
        public fSwingSettings()
        {
            InitializeComponent();
        }

        private void localUpdateSwingSettings()
        {
            Swing.Instance.tic_data = (byte)nudData.Value;
            Swing.Instance.tic_clear = (byte)nudData.Value;
            Swing.Instance.tic_clk = (byte)nudData.Value;
            Swing.Instance.tic_latch = (byte)nudData.Value;
            Swing.Instance.tic_pause = (UInt16)nudPause.Value;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            localUpdateSwingSettings();

            Swing.Instance.saveToFile();
            Close();
        }

        private void fSwingSettings_Load(object sender, EventArgs e)
        {
            Swing.Instance.getFromFile();

            nudData.Value = Swing.Instance.tic_data;
            nudClear.Value = Swing.Instance.tic_clear;
            nudClk.Value = Swing.Instance.tic_clk;
            nudLatch.Value = Swing.Instance.tic_latch;
            nudPause.Value = Swing.Instance.tic_pause;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            localUpdateSwingSettings();

            comDataSender.SendSettings();
        }

        private void fSwingSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Swing.Instance.getFromFile();
        }
    }
}
