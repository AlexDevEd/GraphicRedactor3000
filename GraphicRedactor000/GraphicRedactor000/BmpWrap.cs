using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace GraphicRedactor000
{
    public class BmpWrap:ICloneable
    {

        public Bitmap Bmp { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        bool isLocked;
        public BmpWrap() { isLocked = false; }
        public BmpWrap(int width, int height)
        {
            Bmp = new Bitmap(width, height);
            Width = width;
            Height = height;
        }

        BitmapData bmpData;
        public void Lock()
        {
            if (!isLocked)
                bmpData = Bmp.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, Bmp.PixelFormat);
            isLocked = true;
        }
        public void Unlock()
        {
            if (isLocked)
                Bmp.UnlockBits(bmpData);
            isLocked = false;
        }

        public object Clone()
        {
            BmpWrap bmpWrap = new BmpWrap();
            bmpWrap.Bmp = (Bitmap)Bmp.Clone();
            bmpWrap.Width = Bmp.Width;
            bmpWrap.Height = Bmp.Height;
            bmpWrap.isLocked = false;

            return bmpWrap;
        }

        public Color GetPixel(int x, int y)
        {
            if (x >= 0 && x < Bmp.Width)
                if (y >= 0 && y < Bmp.Height)
                    if (!isLocked)
                        return Bmp.GetPixel(x, y);
                    else
                    {
                        unsafe
                        {
                            byte* currentPixel = (byte*)bmpData.Scan0 + (y * bmpData.Stride) + x * 4;
                            byte B = currentPixel[0];
                            byte G = currentPixel[1];
                            byte R = currentPixel[2];
                            byte A = currentPixel[3];
                            return Color.FromArgb(A, R, G, B);
                        }
                    }
            return Color.Transparent;
        }

        public void SetPixel(int x, int y, Color color)
        {
            if (x >= 0 && x < Bmp.Width)
                if (y >= 0 && y < Bmp.Height)
                    if (!isLocked)
                        Bmp.SetPixel(x, y, color);
                    else
                    {
                        unsafe
                        {
                            byte* currentPixel = (byte*)bmpData.Scan0 + (y * bmpData.Stride) + x * 4;
                            byte B = currentPixel[0];
                            byte G = currentPixel[1];
                            byte R = currentPixel[2];
                            byte A = currentPixel[3];
                        }
                    }
        }
    }
}
