using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCommandActions
{
    public partial class GandalfForm : Form
    {
        
        private Image gandalfImage;
        private int i;

        public GandalfForm()
        {
            InitializeComponent();
        }

        private void GandalfForm_Load(object sender, EventArgs e)
        {
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - Height);
            gandalfImage = (Image)pictureBox.Image.Clone();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rotateTimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }
            pictureBox.Image = RotateImage(gandalfImage, (180f * rotateTimer.Interval / 1000f)*i++);
        }

        private static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
    }
}
