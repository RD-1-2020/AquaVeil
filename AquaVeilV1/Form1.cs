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
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        clMap Map;

        /// <summary>
        /// Ширина кадра в lvFrameList
        /// </summary>
        Int32 _flFrameWidth = 60;

        /// <summary>
        /// Высота кадра в lvFrameList
        /// </summary>
        Int32 _flFrameHeight = 40;

        private void tslColorExBack_Click(object sender, EventArgs e)
        {
            cdColorChange.ShowDialog();
            Map.ColorPenForeground = cdColorChange.Color;
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            Map = new clMap();
        }

        private void tslColorExPen_Click(object sender, EventArgs e)
        {
            cdColorChange.ShowDialog();
            Map.ColorPenBackground = cdColorChange.Color;
        }

        private void lvFrameListInit() {
            lvFrameList.LargeImageList = new ImageList();
            lvFrameList.LargeImageList.ImageSize = new Size(_flFrameWidth, _flFrameHeight);
        }

        private void tsBTNewFrame_Click(object sender, EventArgs e)
        {
            if (lvFrameList.LargeImageList == null) {
                lvFrameListInit();
            }
        }
    }
}
