using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AquaVeilV1.DataSenders;
using AquaVeilV1.Draw;
using AquaVeilV1.Settings;
using AquaVeilV1.Utils;

namespace AquaVeilV1.Forms
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();

            Maps = new LinkedList<clMap>();
        }

        clMap Map;
        LinkedList<clMap> Maps; // Возможно следует пользоваться сразу листом listView!

        private ComDataSender comDataSender;

        /// <summary>
        /// Размер кадров отображаемых в listView
        /// </summary>
        private static Int32 lvImageSize = 2400;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        private static Int32 posX = 20;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        private static Int32 posY = 10;

        /// <summary>
        /// Положение панели цветов по иксу совпдает с posX
        /// </summary>
        private static Int32 posCPX = posX;

        /// <summary>
        /// Положение панели цветов
        /// </summary>
        private static Int32 posCPY = 10;

        private Point lastClickedPix = new Point(-1,-1);

        private void Drawing() {
            if (Map == null)
                return;
            
            
            Graphics g = pbFrameRedact.CreateGraphics();
            g.DrawImage(Map.getBitmap(), posX, posY); // Отображение самого кадра
            g = pbColorPanel.CreateGraphics(); // Пикчер бокс под цветовую панель
            g.DrawImage(Map.getColorsBitmap(), posCPX, posCPY); // Отображение цветовой панели

            //lvFrameListRefreshList(); // Немного ресурсозатратно
        }

        private void refreshExColor() {
            tsLColorExBack.BackColor = Map.ColorPenBackground;
            tsLColorExPen.BackColor = Map.ColorPenForeground;
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
            int lvWidth = (int)Math.Sqrt(Frame.Instance.Width * lvImageSize / Frame.Instance.Height);
            int lvHeight = (int)Math.Sqrt((Frame.Instance.Height * lvImageSize / Frame.Instance.Width));

            if (lvHeight > 256)
            {
                lvHeight = 255;
            }

            if (lvWidth > 256)
            {
                lvWidth = 255;
            }

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

        private void SettingsView()
        {
            scColorPanel.SplitterDistance = Frame.Instance.HeightPix + posCPY * 2;
            while (Frame.Instance.Width * Frame.Instance.WidthPix > scFrame.Panel2.Width - posX)
            {
                Frame.Instance.WidthPix--;
                Frame.Instance.HeightPix--;
            }

            while (Frame.Instance.Height * Frame.Instance.HeightPix > scFrame.Panel2.Height - posY)
            {
                Frame.Instance.WidthPix--;
                Frame.Instance.HeightPix--;
            }

            if (Frame.Instance.Width > 100)
            {
                lvImageSize = Frame.Instance.Width * Frame.Instance.Width + Frame.Instance.Height * Frame.Instance.Height;
            }

            tssiSettingsLabel.Text = $"Размер кадра: {Frame.Instance.Width} x {Frame.Instance.Height}";
        }

        private void tsBTNewFrame_Click(object sender, EventArgs e)
        {
            SettingsView();
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
            lvFrameListRefreshList();

            refreshExColor();

            Drawing();
        }

        private void tsmSaveTo_Click(object sender, EventArgs e)
        {
            string Path;
            int num = 1;
            if (fbdExplorer.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Path = fbdExplorer.SelectedPath;
                foreach (clMap map in Maps) {
                    map.printFramesToFiles(num);
                    num++;
                }
        }

        private void pbColorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (Map == null)
                return;

            Int32 x = e.X;
            Int32 y = e.Y;

            Int32 xx = (x - posX) / Map.PixelWidth;
            Int32 yy = (y - posY) / Map.PixelHeight;

            cdColorChange.ShowDialog();

            Map.changeColumnColor(cdColorChange.Color, xx);

            Drawing();
        }

        private void miAddSomeFrames_Click(object sender, EventArgs e)
        {
            // Добавить форму с количеством кадров
            SettingsView();
            Map = new clMap();
            Map.CreateCanvas();
        }

        private void frMain_Resize(object sender, EventArgs e)
        {
            if (Maps == null)
            {
                return;
            }

            Frame.Instance.WidthPix = 30;
            Frame.Instance.HeightPix = 30;
            SettingsView();

            foreach (var VARIABLE in Maps)
            {
                VARIABLE.PixelWidth = Frame.Instance.WidthPix;
                VARIABLE.PixelHeight = Frame.Instance.HeightPix;
            }

            lvFrameListRefreshList();

            Drawing();
        }

        private void pbFrameRedact_MouseMove(object sender, MouseEventArgs e)
        {
            if (Map == null || e.Button!= MouseButtons.Left)
                return;

            Int32 x = e.X;
            Int32 y = e.Y;

            Int32 xx = (x - posX) / Map.PixelWidth;
            Int32 yy = (y - posY) / Map.PixelHeight;

            if (xx == lastClickedPix.X && yy == lastClickedPix.Y)
            {
                return;
            }

            lastClickedPix = new Point(xx, yy);

            if (Map.InvertPixel(xx, yy))
            {
                Drawing();
            }
        }

        private void tsiSettings_Click(object sender, EventArgs e)
        {
            new fSettingsRedact().ShowDialog();
            Drawing();
        }

        private void tsiConnect_Click(object sender, EventArgs e)
        {
            new Thread(
                delegate()
            {
                MessageBox.Show(new TcpDataSender().Connect());
            }
                ).Start();
        }

        private void tsBTNewFrame_ButtonClick(object sender, EventArgs e)
        {
            TcpDataSender tcpData = new TcpDataSender();
            for (int i = 0; i < 8; i++)
            {
                tcpData.SendCommand(i);
            }
        }

        private void mfsiImportImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK || Map == null)
            {
                return;
            }

            Bitmap importBmp = new Bitmap(openFileDialog.FileName);

            Map.InsertBmp(importBmp);

            Drawing();
        }

        private void tsslTcpResponce_Click(object sender, EventArgs e)
        {
            new fTCPResponse().ShowDialog();
        }

        private void tsmiComConnect_Click(object sender, EventArgs e)
        {
            comDataSender = new ComDataSender();

            new Thread(delegate()
            {
                comDataSender.Connect();
            }).Start();
        }

        private void tsmiComTest_Click(object sender, EventArgs e)
        {
            new Thread(delegate()
            {
                if (comDataSender == null)
                {
                    Logger.error("Попытка отправить данные без соединения с устройством");

                    return;
                }

                comDataSender.SendTestData();
            }).Start();
        }
    }
}
