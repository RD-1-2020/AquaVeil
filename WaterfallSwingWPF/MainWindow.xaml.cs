using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AquaVeilV1;

namespace WaterfallSwingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        Int32 posX = 20;

        /// <summary>
        /// Положение редактируемого кадра
        /// </summary>
        Int32 posY = 40;

        private clMap Map;

        public MainWindow()
        {
            InitializeComponent();
        }

        public static BitmapSource ToBitmapSource(DrawingImage source)
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            DrawingContext drawingContext = drawingVisual.RenderOpen();
            drawingContext.DrawImage(source, new Rect(new Point(0, 0), new Size(source.Width, source.Height)));
            drawingContext.Close();

            RenderTargetBitmap bmp = new RenderTargetBitmap((int)source.Width, (int)source.Height, 96, 96, PixelFormats.Pbgra32);
            bmp.Render(drawingVisual);
            return bmp;
        }

        private void Drawing()
        {
            if (Map == null)
                return;

            DrawingImage frameBitmap = new DrawingImage();

            GeometryDrawing g = new GeometryDrawing();

            frameBitmap.Drawing = Map.getBitmapImage();

            MainCanvas.Source = ToBitmapSource(frameBitmap);
        }

        private void MainCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Map = new clMap();
            double x = e.GetPosition(ImageGrid).X;
            double y = e.GetPosition(ImageGrid).Y;

            double xx = (x - posX) / Map.PixelWidth;
            double yy = (y - posY) / Map.PixelHeight;

            Map.InvertPixel((int)xx, (int)yy);
            Drawing();
        }
    }
}
