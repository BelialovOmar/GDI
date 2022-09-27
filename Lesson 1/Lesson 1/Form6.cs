using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Lesson_1
{
    public partial class Form6 : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        public Form6()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveScreenshot.ShowDialog() == DialogResult.OK)
            {
                // Hide the form so that it does not appear in the screenshot
                this.Hide();

                Thread.Sleep(5000);
                                
                // Set the bitmap object to the size of the screen
                bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                // Create a graphics object from the bitmap
                gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                // Take the screenshot from the upper left corner to the right bottom corner
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                // Save the screenshot to the specified path that the user has chosen
                bmpScreenshot.Save(saveScreenshot.FileName = DateTime.Now.ToString().Replace(".", " "), ImageFormat.Jpeg);
                // Show the form again
                this.Show();
            }
        }

        private void saveScreenshot_FileOk(object sender, CancelEventArgs e)
        {
            bmpScreenshot.Save(saveScreenshot.FileName = DateTime.Now.ToString().Replace(".", " "), ImageFormat.Jpeg);

        }
    }
}
