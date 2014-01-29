using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TestHaarCSharp
{
    public partial class HaarViewer : Form
    {
        public HaarViewer()
        {
            InitializeComponent();
            OriginalImage = (Bitmap)pictureBox1.Image;
        }

        public Bitmap OriginalImage { get; private set; }

        public Bitmap TransformedImage { get; private set; }

        public Bitmap ApplyHaarTransform(bool forward, bool safe, Bitmap bmp)
        {
            return ApplyHaarTransform(forward, safe, GetMaxScale(bmp), bmp);
        }

        public Bitmap ApplyHaarTransform(bool forward, bool safe, int iterations, Bitmap bmp)
        {
            var maxScale = GetMaxScale(bmp);
            if (iterations < 1 || iterations > maxScale)
            {
                MessageBox.Show(string.Format("Iteration must be Integer from 1 to {0}", maxScale));
                return null;
            }

            var time = Environment.TickCount;

            var channels = ColorChannels.CreateColorChannels(safe, bmp.Width, bmp.Height);

            var transform = WaveletTransform.CreateTransform(forward, iterations);

            channels.SeparateColors(bmp);
            transform.Transform(channels);
            channels.MergeColors(bmp);

            if (forward)
            {
                TransformedImage = new Bitmap(bmp);
            }

            pictureBox1.Image = bmp;
            lblDirection.Text = forward ? "Forward" : "Inverse";
            lblTransformTime.Text = string.Format("{0} milis.", (Environment.TickCount - time));

            return bmp;
        }

        private static int GetMaxScale(Bitmap bmp)
        {
            var maxScale = (int)(Math.Log(bmp.Width < bmp.Height ? bmp.Width : bmp.Height) / Math.Log(2));
            return maxScale;
        }

        private void ApplyHaarTransform(bool forward, bool safe, string iterations)
        {
            int i;
            int.TryParse(iterations, out i);
            ApplyHaarTransform(forward, safe, i);
        }

        private void ApplyHaarTransform(bool forward, bool safe, int iterations)
        {
            var bmp = forward ? new Bitmap(OriginalImage) : new Bitmap(TransformedImage);
            ApplyHaarTransform(forward, safe, iterations, bmp);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tif)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var tempbitmap = new Bitmap(open.FileName);
                if (((tempbitmap.Width & (tempbitmap.Width - 1)) != 0) ||
                    ((tempbitmap.Height & (tempbitmap.Height - 1)) != 0))
                {
                    MessageBox.Show("Image width and height must be power of 2!");
                    return;
                }
                OriginalImage = tempbitmap;
                pictureBox1.Image = OriginalImage;
                lblWidth.Text = OriginalImage.Width.ToString();
                lblHeight.Text = OriginalImage.Height.ToString();
            }
        }

        private void btnForwardSafe_Click(object sender, EventArgs e)
        {
            ApplyHaarTransform(true, true, txtIterations.Text);
        }

        private void btnForwardUnsafe_Click(object sender, EventArgs e)
        {
            ApplyHaarTransform(true, false, txtIterations.Text);
        }

        private void btnInverseSafe_Click(object sender, EventArgs e)
        {
            ApplyHaarTransform(false, true, txtIterations.Text);
        }

        private void btnInverseUnsafe_Click(object sender, EventArgs e)
        {
            ApplyHaarTransform(false, false, txtIterations.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tif";
            var format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;

                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;

                    case ".gif":
                        format = ImageFormat.Gif;
                        break;

                    case ".png":
                        format = ImageFormat.Png;
                        break;

                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }
        }
    }
}