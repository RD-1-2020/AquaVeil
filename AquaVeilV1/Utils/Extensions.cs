using System.Drawing;

namespace AquaVeilV1.Utils
{
    public static class Extensions
    {
        public static void ToMonochrome(this Bitmap bitmap)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var pix = bitmap.GetPixel(x, y);

                    if ((pix.R + pix.G + pix.B) / 3 <= 112)
                    {
                        bitmap.SetPixel(x, y,Color.White);
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.Black);
                    }
                }
            }
        }
    }
}
