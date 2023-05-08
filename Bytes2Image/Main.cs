using System.Diagnostics;
using System.Drawing.Imaging;

namespace Bytes2Image
{
    public partial class Main : Form
    {
        Settings settings = new Settings();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            settings.DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            settings.CanRead = false;
            settings.imgSize = 0;
            settings.AllBytes = 0;
            settings.FilePath = String.Empty;
            settings.Save();
            refreshUI();
        }

        private void selBtn_Click(object sender, EventArgs e)
        {
            selectPath();
        }

        private void pathTxt_Click(object sender, EventArgs e)
        {
            selectPath();
        }

        private void selectPath()
        {
            fileDialog.InitialDirectory = settings.DesktopPath;
            fileDialog.Filter = "All files (*.*)|*.*";
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            if (!File.Exists(fileDialog.FileName))
            {
                MessageBox.Show("Can't open file.", "⚠ Error.");
                return;
            }
            settings.FilePath = fileDialog.FileName;

            FileInfo fileInfo = new FileInfo(settings.FilePath);
            Debug.WriteLine(fileInfo.Length);

            if (fileInfo.Length >= Convert.ToInt64(2147483648))
            {
                MessageBox.Show("File is more than 2GB!", "⚠ Error.");
                return;
            }

            pathTxt.Text = settings.FilePath;
            settings.AllBytes = fileInfo.Length;
            settings.imgSize = (int)Math.Sqrt(settings.AllBytes) + 2;
            settings.CanRead = true;

            settings.Save();

            refreshUI();
        }
        private void refreshUI()
        {
            if (settings.CanRead) rwbytes.Enabled = true;
            if (!settings.CanRead) rwbytes.Enabled = false;

            if(settings.rw) rwbytes.Text = "Read";
            if (!settings.rw) rwbytes.Text = "Write";
        }

        private void ImageToFile()
        {
            try
            {
                using (Image image = Image.FromFile(settings.FilePath))
                {
                    Bitmap bitmap = new Bitmap(image);
                    int imgSize = (bitmap.Height * bitmap.Width);
                    int imgX = 0;
                    int imgY = 0;
                    int percentage = 0;
                    int curbyte = 0;

                    int oldX = 0;
                    int oldY = 0;

                    bool running = true;

                    int height = bitmap.Height - 1;

                    Color currPixel = Color.Red;
                    Color oldPixel = Color.Green;

                    liveView.Image = bitmap;

                    List<byte> b = new List<byte>();
                    setSizeTxt(bitmap.Height + " x " + bitmap.Width, imgSize.ToString(), "???", "???");

                    while(running)
                    {
                        currPixel = bitmap.GetPixel(imgX, imgY);

                        if (livePreview.Checked)
                        {
                            setCoordsTxt(imgX.ToString() + ";" + imgY.ToString());
                            bitmap.SetPixel(imgX, imgY, Color.FromArgb(255, percentage * 2, 0, 0));
                            liveView.Image = bitmap;
                        }

                        if (currPixel.A < 255) running = false;

                        b.Add(currPixel.R);
                        percentage = (int)((double)curbyte / imgSize * 100);
                        setPercentage(percentage.ToString() + "%", percentage);

                        curbyte++;

                        if (imgX < height)
                        {
                            imgX++;
                        }
                        else
                        {
                            imgX = 0;
                            imgY++;
                        }
                    }
                    percentage = 100;
                    setPercentage(percentage.ToString() + "%", percentage);
                    byte[] bArray = b.ToArray();

                    string tempstr = Path.GetFileName(settings.FilePath).ToString();

                    File.WriteAllBytes(settings.FilePath.Replace((Path.GetFileName(settings.FilePath)), "") + @"\ " + tempstr.Substring(0, tempstr.Length-4), bArray);
                }
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Not a valid image!", "⚠ Error.");
                return;
            }
        }

        private byte[] AddByteToArray(byte[] bArray, byte newByte)
        {
            byte[] newArray = new byte[bArray.Length + 1];
            bArray.CopyTo(newArray, 1);
            newArray[0] = newByte;
            return newArray;
        }

        private void FileToImage()
        {
            pbRBytes.Maximum = 100;
            pbRBytes.Minimum = 0;

            long curbyte = 0;
            int percentage = 0;
            var bitmap = new Bitmap(settings.imgSize, settings.imgSize);

            int imgX = 0;
            int imgY = 0;

            int imgSize = (settings.imgSize * settings.imgSize);

            setSizeTxt(settings.imgSize.ToString() + " x " + settings.imgSize.ToString(), imgSize.ToString(), settings.AllBytes.ToString(), (imgSize - settings.AllBytes).ToString());

            liveView.Image = bitmap;

            using (StreamWriter writer = new StreamWriter(settings.BytesFile))
            {
                byte[] readFile = File.ReadAllBytes(settings.FilePath);
                foreach (byte b in readFile)
                {
                    bitmap.SetPixel(imgX, imgY, Color.FromArgb(255, b, b, b));

                    if (livePreview.Checked)
                    {
                        liveView.Image = bitmap;
                        setCoordsTxt(imgX.ToString() + ";" + imgY.ToString());
                    }
                    curbyte++;
                    //writer.Write(b);
                    if (curbyte < settings.AllBytes) writer.Write(",");

                    if (imgX < settings.imgSize - 1)
                    {
                        imgX++;
                    }
                    else
                    {
                        imgX = 0;
                        imgY++;
                    }

                    percentage = (int)((double)curbyte / settings.AllBytes * 100);
                    setPercentage(percentage.ToString() + "%", percentage);
                }
                bitmap.Save(settings.FilePath.Replace((Path.GetFileName(settings.FilePath)), "") + @"\" + Path.GetFileName(settings.FilePath).ToString() + ".png", ImageFormat.Png);
                liveView.Image = Image.FromFile(settings.FilePath.Replace((Path.GetFileName(settings.FilePath)), "") + @"\" + Path.GetFileName(settings.FilePath).ToString() + ".png");

                bitmap.Dispose();
            }
        }

        private void setImage(Image img)
        {
            this.Invoke(() => liveView.Image = img);
        }
        private void setPercentage(string txt, int percentage)
        {
            this.Invoke(() => pbRBytes.Value = percentage);
            this.Invoke(() => currentProgressLabel.Text = txt);
        }
        private void setSizeTxt(string txt, string bPixelsTxt, string mPixelsTxt, string nPixelsTxt)
        {
            this.Invoke(() => imgsize.Text = txt);
            this.Invoke(() => basePixels.Text = bPixelsTxt);
            this.Invoke(() => maxPixels.Text = mPixelsTxt);
            this.Invoke(() => nullPixels.Text = nPixelsTxt);
        }
        private void setCoordsTxt(string txt)
        {
            this.Invoke(() => coordsLabel.Text = txt);
        }

        private void rbytes_Click(object sender, EventArgs e)
        {
            if (!settings.CanRead) return;
            if(settings.rw)
            {
                Thread readBytesThread = new Thread(new ThreadStart(FileToImage));
                readBytesThread.Start();
            } 
            else
            {
                Thread writeBytesThread = new Thread(new ThreadStart(ImageToFile));
                writeBytesThread.Start();
            }
        }

        private void switchRW_Click(object sender, EventArgs e)
        {
            settings.rw = !settings.rw;
            settings.Save();
            refreshUI();
        }
    }
}
