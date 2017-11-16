using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOptimize
{
    public partial class Main : Form
    {
        Main main;
        public Main()
        {
            InitializeComponent();
            processUpdate = new d1Param(processUpdateFunc);
            main = this;
        }
        public delegate void d1Param(Boolean runStt);
        public d1Param processUpdate;

        public void processUpdateFunc(Boolean runStt)
        {
            if (runStt)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                btnStart.Enabled = false;
            }
            else
            {
                progressBar.Style = ProgressBarStyle.Blocks;
                btnStart.Enabled = true;
            }
        }

        private void btnImgFoldInput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtImgFoldInput.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnImgFoldOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtImgFoldOut.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string inputFold = txtImgFoldInput.Text;
            string outputFold = txtImgFoldOut.Text;
            string maxWidth = txtMaxWidth.Text;
            if (string.IsNullOrEmpty(inputFold) || string.IsNullOrEmpty(outputFold))
            {
                MessageBox.Show("Please choose output and input folder", "Errrors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var t = new Thread(() =>
                {
                    try
                    {
                        main.Invoke(main.processUpdate, true);

                        var filters = new String[] { "jpg", "jpeg", "png", "gif" };
                        var files = GetFilesFrom(inputFold, filters, false);
                        foreach (var item in files)
                        {
                            using (MagickImage image = new MagickImage(item))
                            {
                                string filenameWithoutPath = Path.GetFileName(item);
                                if (image.Width > 1024)
                                    image.Resize(Int32.Parse(maxWidth), 0);
                                image.Format = MagickFormat.Jpg;
                                image.AddProfile(ColorProfile.SRGB);
                                image.CompressionMethod = CompressionMethod.JPEG;
                                image.Quality = 80;
                                image.Write(outputFold + '\\' + filenameWithoutPath);
                            }
                        }
                        main.Invoke(main.processUpdate, false);
                        Process.Start(outputFold);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check again your images, error happened!!", "Errrors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        main.Invoke(main.processUpdate, false);
                    }
                });
                t.IsBackground = true;
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }

        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
    }
}
