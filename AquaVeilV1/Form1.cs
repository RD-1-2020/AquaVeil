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
            g.DrawImage(Map.getBitmap(), posX, posY);
            g.DrawImage(Map.getColorsBitmap(), posCPX, posCPY);

            lvFrameListRefreshList(); // Немного ресурсозатратно
        }

        private void refreshExColor() {
            this.tslColorExBack.BackColor = Map.ColorPenBackground;
            this.tslColorExPen.BackColor = Map.ColorPenForeground;
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

            int lvWidth = (int)Math.Sqrt(Settings.Width * lvImageSize / Settings.Height);
            int lvHeight = (int)Math.Sqrt((Settings.Height * lvImageSize / Settings.Width) <= lvImageSize/10 ? 
                (Settings.Height * lvImageSize / Settings.Width) *5 :((Settings.Height * lvImageSize / Settings.Width)));

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

        /// <summary>
        /// Вызывает новую форму для изменения текущих настроек проекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSettingsRedact_Click(object sender, EventArgs e) // Сделать вызов формы под редактрирование
        {
            if (Maps != null) // Временно потом вызывать метод refreshSize() для каждого элемента Maps
                return;
        }

        private void saveFramesToFile(string Path) {
            string fileText = "";
            int num = 1;
            foreach (clMap map in Maps)
            {
                string fileName = @"Frame" + num +".txt";
                fileText += Convert.ToString(Maps.Count, 16) + "\n";
                fileText += Convert.ToString(Settings.Width, 16) + "\n";
                fileText += Convert.ToString(Settings.Height, 16) + "\n";
                

                for (int i = 0; i < map.MapCanvas[i].Length; i++)
                {
                    for (int j = 0; j < map.MapCanvas.Length; j++)
                    {
                        fileText += map.MapCanvas[j][i];
                    }
                    fileText += "\n";
                }


                using (StreamWriter FileFrame = new StreamWriter(Path+@"\" + fileName, false, System.Text.Encoding.Default))
                {
                    FileFrame.Write(fileText);
                }


                fileText = "";
                num++;
            }
        }

        private void saveColorToFile(string Path)
        {
            string fileText = "";
            int num = 1;
            foreach (clMap map in Maps)
            {
                string fileName = "Frame" + num +"Color.txt";
                for (int i = 0; i < map.Width; i++)
                {
                    
                    fileText += Convert.ToString(map.ColumnColor[i].R,16) + (map.ColumnColor[i].R == 0 ? "0" : "");
                    fileText += Convert.ToString(map.ColumnColor[i].G, 16) + (map.ColumnColor[i].G == 0 ? "0" : "");
                    fileText += Convert.ToString(map.ColumnColor[i].B, 16) + (map.ColumnColor[i].B == 0 ? "0" : "");
                    fileText += "\n";
                }

                using (StreamWriter FileFrame = new StreamWriter(Path + @"\" + fileName, false, System.Text.Encoding.Default))
                {
                    FileFrame.Write(fileText);
                }
                fileText = "";
                num++;
            }
        }



        private void tsmSaveTo_Click(object sender, EventArgs e)
        {
            string Path;
            if (fbdExplorer.ShowDialog() == DialogResult.OK) {
                Path = fbdExplorer.SelectedPath;

                saveFramesToFile(Path);

                saveColorToFile(Path);
            }
        }
    }
}
