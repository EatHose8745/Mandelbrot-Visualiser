using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Drawing.Imaging;

namespace Mandelbrot_Visualiser
{
    public class Mandelbrot
    {
        public DirectBitmap bitmap;

        public double power;

        public int iterations;
        public int imageWidth;
        public int imageHeight;
        public double[] xScaleBounds = new double[2];
        public double[] yScaleBounds = new double[2];
        public double[][] initialScaleBounds = new double[2][];

        public Mandelbrot(int width = 100, int height = 100, double power = 2, double xMin = -2, double yMin = -2, double xMax = 2, double yMax = 2, double zoom = 1,int iterations = 50)
        {
            this.bitmap = new DirectBitmap(width, height);
            this.power = power;
            this.imageWidth = width;
            this.imageHeight = height;
            this.xScaleBounds[0] = xMin / zoom;
            this.yScaleBounds[0] = yMin / zoom;
            this.xScaleBounds[1] = xMax / zoom;
            this.yScaleBounds[1] = yMax / zoom;
            this.initialScaleBounds[0] = xScaleBounds;
            this.initialScaleBounds[1] = yScaleBounds;
            this.iterations = iterations;
        }

        public void Render()
        {
            int count = 0;
            int total = imageWidth * imageHeight;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    double real = MapPixelToScale(x, imageWidth, xScaleBounds[0], xScaleBounds[1]);
                    double imaginary = MapPixelToScale(y, imageHeight, -yScaleBounds[0], -yScaleBounds[1]);
                    bitmap.SetPixel(x, y, Iterate(new Complex(real, imaginary), iterations));
                    count++;
                }
            }
        }

        private double MapPixelToScale(int n, int size, double min, double max)
        {
            double range = max - min;

            return n * (range / size) + min;
        }

        private Color ColourOfZ(int n)
        {
            //RGB rgb = ColorHelper.ColorConverter.HsvToRgb(new HSV(n, 100, 100));
            //return Color.FromArgb(255, rgb.R, rgb.G, rgb.B);

            int r, g, b;
            HsvToRgb(n, 1, 1, out r, out g, out b);
            return Color.FromArgb(255, r, g, b);
        }

        private void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;
                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;
                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;
                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;
                    default:
                        R = G = B = V;
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        private int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        private Color Iterate(Complex c, int iterations)
        {
            Complex z = 0;
            
            for (int i = 0; i < iterations; i++)
            {
                if (!IsMandelbrot(z))
                    return ColourOfZ(i);
                z = z * z + c;
            }
            return Color.Black;
        }

        private bool IsMandelbrot(Complex z)
        {
            return z.Real * z.Real + z.Imaginary * z.Imaginary <= 4;
        }
    }
}
