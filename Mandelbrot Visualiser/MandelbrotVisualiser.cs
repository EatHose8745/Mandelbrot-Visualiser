using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mandelbrot_Visualiser
{
    public partial class VisualiserWindow : Form
    {
        public Mandelbrot mandelbrot = new Mandelbrot();

        private double zoomValue = 1;
        private double zoomIncrement = 2;

        private int mouseX = 0;
        private int mouseY = 0;

        private double recordedXOffset = 0;
        private double recordedYOffset = 0;
        private double offsetIncrement = 0.1;

        private Stopwatch renderStopwatch = new Stopwatch();

        public VisualiserWindow()
        {
            InitializeComponent();
            //this.MandelbrotPanel.MouseWheel += new MouseEventHandler(MandelbrotPanel_MouseWheel);
            this.MandelbrotPictureBox.MouseWheel += new MouseEventHandler(MandelbrotPanel_MouseWheel);
            this.MandelbrotPictureBox.MouseClick += new MouseEventHandler(MandelbrotPanel_MouseClick);
            this.MandelbrotPictureBox.Paint += new PaintEventHandler(MandelbrotPanel_Paint);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void MandelbrotPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((zoomValue * zoomIncrement <= 0.001 && e.Delta > 0) || (zoomValue / zoomIncrement <= 0.001 && e.Delta < 0))
            {
                zoomValue = 0.001;
            }

            if (e.Delta > 0)
            {
                zoomValue *= zoomIncrement;
            }
            else if (e.Delta < 0)
            {
                zoomValue /= zoomIncrement;
            }
            //zoomValue = (double)decimal.Round((decimal)zoomValue, 1);
            Render(recordedXOffset, recordedYOffset, zoomValue);
            //Console.WriteLine(zoomValue);
            
        }

        private double MapLocationToScale(double n, int size, double min, double max)
        {
            double range = max - min;

            return n * (range / size) + min;
        }

        private void Render(double xOffset = 0, double yOffset = 0, double zoom = 1)
        {
            renderStopwatch.Start();
            mandelbrot.xScaleBounds = new double[2] { (mandelbrot.initialScaleBounds[0][0] / (zoom)) + xOffset, (mandelbrot.initialScaleBounds[0][1] / (zoom)) + xOffset };
            mandelbrot.yScaleBounds = new double[2] { (mandelbrot.initialScaleBounds[1][0] / (zoom)) + yOffset, (mandelbrot.initialScaleBounds[1][1] / (zoom)) + yOffset };
            mandelbrot.Render();
            renderStopwatch.Stop();
            Console.WriteLine($"Time Took: {renderStopwatch.Elapsed} Seconds");
            renderStopwatch.Reset();
            //MandelbrotPanel.BackgroundImage = (Image)mandelbrot.bitmap;
            MandelbrotPictureBox.Refresh();
        }

        private void VisualiserWindow_Load(object sender, EventArgs e)
        {
            mandelbrot = new Mandelbrot(MandelbrotPictureBox.Width, MandelbrotPictureBox.Height, 2, -2, -2, 2, 2, 1, 250);
            Render(0, 0, zoomValue);
        }

        private void xOffsetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void ShiftView_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "ShiftViewUp":
                    recordedYOffset -= offsetIncrement;
                    break;
                case "ShiftViewRight":
                    recordedXOffset += offsetIncrement;
                    break;
                case "ShiftViewDown":
                    recordedYOffset += offsetIncrement;
                    break;
                case "ShiftViewLeft":
                    recordedXOffset -= offsetIncrement;
                    break;
            }
            
            Render(recordedXOffset / zoomValue, recordedYOffset / zoomValue, zoomValue);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.zoomValue = 1;
            this.recordedXOffset = 0;
            this.recordedYOffset = 0;
            Render(recordedXOffset, recordedYOffset, zoomValue);
        }

        private void MandelbrotPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.mouseX = e.X;
            this.mouseY = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                double xOffset = MapLocationToScale(e.X, mandelbrot.imageWidth, mandelbrot.xScaleBounds[0], mandelbrot.xScaleBounds[1]);
                double yOffset = MapLocationToScale(e.Y, mandelbrot.imageHeight, mandelbrot.yScaleBounds[0], mandelbrot.yScaleBounds[1]);
                Render(recordedXOffset = xOffset , recordedYOffset = yOffset , zoomValue);
            }
            //Console.WriteLine($"{e.X}, {e.Y}");
        }

        private void PowerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void MandelbrotPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mandelbrot.bitmap.Bitmap, 0, 0);
        }

        private void IterationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(IterationTextBox.Text, out _))
            {
                mandelbrot.iterations = int.Parse(IterationTextBox.Text);
                Render(recordedXOffset, recordedYOffset, zoomValue);
            }
        }

        private void IterationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void VisualiserWindow_SizeChanged(object sender, EventArgs e)
        {
            this.MandelbrotPictureBox.Size = new Size(this.Width - 233, this.Height - 39);
            this.mandelbrot.imageWidth = this.MandelbrotPictureBox.Size.Width;
            this.mandelbrot.imageHeight = this.MandelbrotPictureBox.Size.Height;
            this.mandelbrot.bitmap = new DirectBitmap(this.mandelbrot.imageWidth, this.mandelbrot.imageHeight);
            this.ControlPanel.Location = new Point(this.MandelbrotPictureBox.Width + 6, 0);
            Render(recordedXOffset, recordedYOffset, zoomValue);
        }
    }
}
