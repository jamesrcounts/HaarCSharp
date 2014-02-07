namespace TestHaarCSharp
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;

    public partial class HaarViewer : Form
    {
        public HaarViewer()
        {
            this.InitializeComponent();
            this.OriginalImage = (Bitmap)this.pictureBox1.Image;
        }

        private Bitmap OriginalImage { get; set; }

        private Bitmap TransformedImage { get; set; }

        private void ApplyHaarTransform(bool forward, bool safe, int iterations, Bitmap bmp)
        {
            var maxScale = WaveletTransform.GetMaxScale(bmp.Width, bmp.Height);
            if (iterations < 1 || iterations > maxScale)
            {
                MessageBox.Show(string.Format("Iteration must be Integer from 1 to {0}", maxScale));
                return;
            }

            var time = Environment.TickCount;

            var channels = ColorChannels.CreateColorChannels(safe, bmp.Width, bmp.Height);

            var transform = WaveletTransform.CreateTransform(forward, iterations);

            var imageProcessor = new ImageProcessor(channels, transform);
            imageProcessor.ApplyTransform(bmp);

            if (forward)
            {
                this.TransformedImage = new Bitmap(bmp);
            }

            this.pictureBox1.Image = bmp;
            this.lblDirection.Text = forward ? "Forward" : "Inverse";
            this.lblTransformTime.Text = string.Format("{0} milis.", Environment.TickCount - time);
        }

        private void ApplyHaarTransform(bool forward, bool safe, string iterations)
        {
            int i;
            int.TryParse(iterations, out i);
            ApplyHaarTransform(forward, safe, i);
        }

        private void ApplyHaarTransform(bool forward, bool safe, int iterations)
        {
            var bmp = forward ? new Bitmap(this.OriginalImage) : new Bitmap(this.TransformedImage);
            this.ApplyHaarTransform(forward, safe, iterations, bmp);
        }

        private void BtnBrowseClick(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
                           {
                               Filter =
                                   "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tif)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tif"
                           };
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var tempbitmap = new Bitmap(open.FileName);
            if (((tempbitmap.Width & (tempbitmap.Width - 1)) != 0)
                || ((tempbitmap.Height & (tempbitmap.Height - 1)) != 0))
            {
                MessageBox.Show("Image width and height must be power of 2!");
                return;
            }

            this.OriginalImage = tempbitmap;
            this.pictureBox1.Image = this.OriginalImage;
            this.lblWidth.Text = this.OriginalImage.Width.ToString(CultureInfo.InvariantCulture);
            this.lblHeight.Text = this.OriginalImage.Height.ToString(CultureInfo.InvariantCulture);
        }

        private void BtnForwardSafeClick(object sender, EventArgs e)
        {
            this.ApplyHaarTransform(true, true, this.txtIterations.Text);
        }

        private void BtnForwardUnsafeClick(object sender, EventArgs e)
        {
            this.ApplyHaarTransform(true, false, this.txtIterations.Text);
        }

        private void BtnInverseSafeClick(object sender, EventArgs e)
        {
            this.ApplyHaarTransform(false, true, this.txtIterations.Text);
        }

        private void BtnInverseUnsafeClick(object sender, EventArgs e)
        {
            this.ApplyHaarTransform(false, false, this.txtIterations.Text);
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog { Filter = "Images|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tif" };
            var format = ImageFormat.Png;
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

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

            this.pictureBox1.Image.Save(sfd.FileName, format);
        }
    }
}