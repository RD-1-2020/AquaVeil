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
        LinkedList<clMap> Maps; // Возможно следует пользоваться сразу листом listView!

        /// <summary>
        /// Ширина кадра в lvFrameList
        /// </summary>
        Int32 _flFrameWidth = 60;

        /// <summary>
        /// Высота кадра в lvFrameList
        /// </summary>
        Int32 _flFrameHeight = 40;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        Int32 posX = 20;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        Int32 posY = 20;

        private void Drawing() {
            if (Map == null)
                return;

            
            Graphics g = pbFrameRedact.CreateGraphics();
            g.DrawImage(Map.getBitmap(), posX, posY);
            
            lvFrameListRefreshList(); // Немного ресурсозатратно
        }

        private void refreshExColor() {
            this.tslColorExBack.BackColor = Map.ColorPenForeground;
            this.tslColorExPen.BackColor = Map.ColorPenBackground;
        }

        private void pbFrameRedact_MouseClick(object sender, MouseEventArgs e)
        {
            Int32 x = e.X;
            Int32 y = e.Y;

            Int32 xx = (x - posX) / Map.PixelWidth;
            Int32 yy = (y - posY) / Map.PixelHeight;

            Map.InvertPixel(xx, yy);
            Drawing();
        }

        private void tslColorExPen_Click(object sender, EventArgs e)
        {
            if (Map == null)
                return;

            cdColorChange.ShowDialog();

            Map.ColorPenBackground = cdColorChange.Color;

            refreshExColor();
            Drawing();
        }

        private void tslColorExBack_Click(object sender, EventArgs e)
        {
            if (Map == null)
                return;

            cdColorChange.ShowDialog();

            Map.ColorPenForeground = cdColorChange.Color;

            refreshExColor();
            Drawing();
        }

        private void lvFrameListInit() {
            lvFrameList.LargeImageList = new ImageList();
            lvFrameList.LargeImageList.ImageSize = new Size(_flFrameWidth, _flFrameHeight);
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
            }

            Map = new clMap();
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
    }
}
