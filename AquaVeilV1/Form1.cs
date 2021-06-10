using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        LinkedList<clMap> Maps; // Возможно следует пользоваться сразу листом listView!

        /// <summary>
        /// Размер кадров отображаемых в listView
        /// </summary>
        Int32 lvImageSize = 2400;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        Int32 posX = 20;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        Int32 posY = 40;

        /// <summary>
        /// Положение панели цветов
        /// </summary>
        Int32 posCPX = 20;

        /// <summary>
        /// Положение панели цветов
        /// </summary>
        Int32 posCPY = 10;

        private void Drawing() {
            if (Map == null)
                return;

            
            Graphics g = pbFrameRedact.CreateGraphics();
            g.DrawImage(Map.getBitmap(), posX, posY); // Отображение самого кадра
            g.DrawImage(Map.getColorsBitmap(), posCPX, posCPY); // Отображение цветовой панели

            lvFrameListRefreshList(); // Немного ресурсозатратно
        }

        private void refreshExColor() {
            tslColorExBack.BackColor = Map.ColorPenBackground;
            tslColorExPen.BackColor = Map.ColorPenForeground;
        }

        private void pbFrameRedact_MouseClick(object sender, MouseEventArgs e)
        {
            if (Map == null)
                return;

            Int32 x = e.X;
            Int32 y = e.Y;

            Int32 xx = (x - posX) / Map.PixelWidth;
            Int32 yy = (y - posY) / Map.PixelHeight;

            if (Map.InvertPixel(xx, yy)) {
                Drawing();
                return;
            }

            if (xx > Map.Width)
                return;
            cdColorChange.ShowDialog();

            Map.changeColumnColor(cdColorChange.Color,xx);

            Drawing();
        }

        private void tslColorExPen_Click(object sender, EventArgs e)
        {
            if (Map == null)
                return;

            cdColorChange.ShowDialog();

            Map.ColorPenForeground = cdColorChange.Color;

            Map.initColor();

            refreshExColor();
            Drawing();
        }

        private void tslColorExBack_Click(object sender, EventArgs e)
        {
            if (Map == null)
                return;

            cdColorChange.ShowDialog();

            Map.ColorPenBackground = cdColorChange.Color;

            refreshExColor();
            Drawing();
        }

        private void lvFrameListInit() {
            lvFrameList.LargeImageList = new ImageList();

            // Расчёт размеров кадра в listView
            int lvWidth = (int)Math.Sqrt(Settings.Width * lvImageSize / Settings.Height);
            int lvHeight = (int)Math.Sqrt((Settings.Height * lvImageSize / Settings.Width));

            lvFrameList.LargeImageList.ImageSize = new Size(lvWidth,lvHeight);
        }

        private void lvFrameListAddNewElement(clMap map, int index) {
            lvFrameList.LargeImageList.Images.Add(map.getBitmap());
            lvFrameList.Items.Add(index.ToString(), index);
        }

        private void lvFrameListRefreshList() {
            lvFrameListInit();
            lvFrameList.Items.Clear();

            int i = 0;
            foreach (clMap map in Maps)
            {
                lvFrameListAddNewElement(map, i);
                i++;
            }
        }

        private void tsBTNewFrame_Click(object sender, EventArgs e)
        {
            if (Maps == null) {
                Maps = new LinkedList<clMap>();
                new fSettingsRedact().ShowDialog(); 
            }

            Map = new clMap();
            Map.CreateCanvas();
            Maps.AddLast(Map);
            lvFrameListRefreshList();

            refreshExColor();
            Drawing();
        }

        private void lvFrameList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int i = 0;
            foreach (clMap map in Maps) {
                if (i == e.ItemIndex)
                {
                    Map = map;
                    break;
                }
                i++;
            }

            refreshExColor();
            Drawing();
        }

        private void tsmSaveTo_Click(object sender, EventArgs e)
        {
            string Path;
            int num = 1;
            if (fbdExplorer.ShowDialog() == DialogResult.OK) {
                Path = fbdExplorer.SelectedPath;
                foreach (clMap map in Maps) {
                    map.printToFiles(num,Path);
                    num++;
                }
            }
        }
    }
}
