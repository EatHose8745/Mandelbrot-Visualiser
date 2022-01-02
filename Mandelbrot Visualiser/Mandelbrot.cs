using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.IO;
using ColorHelper;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Drawing.Imaging;

namespace Mandelbrot_Visualiser
{
    public class Mandelbrot
    {
        public Bitmap bitmap;

        public int iterations;
        public int imageWidth;
        public int imageHeight;
        public double[] xScaleBounds = new double[2];
        public double[] yScaleBounds = new double[2];
        public double[][] initialScaleBounds = new double[2][];

        public Mandelbrot(int width = 100, int height = 100, double xMin = -2, double yMin = -2, double xMax = 2, double yMax = 2, double zoom = 1,int iterations = 50)
        {
            this.bitmap = new Bitmap(width, height);
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
            RGB rgb = ColorHelper.ColorConverter.HsvToRgb(new HSV(n, 100, 100));
            return Color.FromArgb(255, rgb.R, rgb.G, rgb.B);
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
