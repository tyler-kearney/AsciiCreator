using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace AsciiArt
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string imgPath = txtPath.Text;

            if (string.IsNullOrEmpty(imgPath))
            {
                MessageBox.Show("Please enter an Image URL or choose a file using the Choose File Button");
                return;
            }

            try
            {
                Bitmap img;

                if (imgPath.StartsWith("http") || imgPath.StartsWith("https"))
                {
                    // Download a temp image
                    using (WebClient client = new WebClient())
                    {
                        byte[] imgBytes = client.DownloadData(imgPath);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img = new Bitmap(ms);
                        }
                    }
                }
                else
                {
                    // Load a local image
                    img = new Bitmap(imgPath);
                }

                string asciiArt = ConvertToAscii(img);
                lstOut.Items.Add(asciiArt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            txtPath.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSave.Filter = "Text Files (*.txt)|*.txt";

            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sfdSave.FileName))
                {
                    foreach (var item in lstOut.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (ofdChoose.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdChoose.FileName;
            }
        }

        private string ConvertToAscii(Bitmap img)
        {
            // String variable that will hold the resulting image
            string asciiImg = "";

            // Resize the image
            int newWidth = 80;
            int newHeight = (int)(img.Height * (double)(newWidth / img.Width));
            Bitmap resized = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(resized);
            g.DrawImage(img, 0, 0, newWidth, newHeight);

            // Convert the image to greyscale
            for (int y = 0; y < resized.Height; y++)
            {
                for (int x = 0; x < resized.Width; x++)
                {
                    Color pixelColor = resized.GetPixel(x, y);
                    int greyscale = (int)(0.299 *  pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    resized.SetPixel(x, y, Color.FromArgb(greyscale, greyscale, greyscale));
                }
            }

            // Convert to Ascii Art
            for (int y = 0; y < resized.Height; y++)
            {
                for (int x = 0; x < resized.Width; x++)
                {
                    int greyscale = resized.GetPixel(x, y).R;
                    char c = ' ';

                    if (greyscale > 230) c = '.';
                    else if (greyscale > 200) c = ':';
                    else if (greyscale > 180) c = '-';
                    else if (greyscale > 160) c = '+';
                    else if (greyscale > 140) c = '*';
                    else if (greyscale > 120) c = '#';
                    else if (greyscale > 100) c = '%';
                    else if (greyscale > 80) c = '@';

                    asciiImg += c;
                }
                asciiImg += "\n";
            }

            return asciiImg;
        }
    }
}
