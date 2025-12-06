using System.Diagnostics;

namespace Bai06
{
    public partial class CopyFile_Form : System.Windows.Forms.Form
    {
        private int totalFiles = 0;
        private int copiedFiles = 0;
        public CopyFile_Form()
        {
            InitializeComponent();
        }

        private void btnFileSour_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtSour.Text = ofd.FileName;
                }
            }

        }

        private void btnFileDes_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDes.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDes.Text) || string.IsNullOrEmpty(txtSour.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ đường dẫn thư mục nguồn và đích");
                return;
            }
            string sourcePath = txtSour.Text;
            string desPath = txtDes.Text;

            if (!Directory.Exists(sourcePath) && !File.Exists(sourcePath))
            {
                MessageBox.Show("Đường dẫn nguồn không tồn tại!");
                return;
            }

            if (!Directory.Exists(desPath))
            {
                MessageBox.Show("Thư mục đích không tồn tại!");
                return;
            }

            copiedFiles = 0;
            totalFiles = CountFiles(sourcePath);

            proBarCopy.Minimum = 0;
            proBarCopy.Maximum = totalFiles;
            proBarCopy.Value = 0;

            try
            {
                if (File.Exists(sourcePath))
                {
                    // Sao chép 1 file
                    CopyFile(sourcePath, Path.Combine(desPath, Path.GetFileName(sourcePath)));
                }
                else
                {
                    // Sao chép thư mục
                    CopyDirectory(sourcePath, Path.Combine(desPath, Path.GetFileName(sourcePath)));
                }

                toolTip.SetToolTip(proBarCopy, $"Tiến trình hoàn tất");
                MessageBox.Show("Sao chép hoàn tất!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private int CountFiles(string path)
        {
            if (File.Exists(path))
                return 1;

            int count = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
            return count;
        }

        private void CopyFile(string sourFile, string desFile)
        {
            File.Copy(sourFile, desFile, true);
            copiedFiles++;
            toolTip.SetToolTip(proBarCopy, $"{sourFile} đang được sao chép");
            proBarCopy.Value = copiedFiles;
            Application.DoEvents();
        }

        private void CopyDirectory(string sourDir, string desDir)
        {
            Directory.CreateDirectory(desDir);

            foreach (string file in Directory.GetFiles(sourDir))
            {
                string desFile = Path.Combine(desDir, Path.GetFileName(file));
                CopyFile(file, desFile);
            }

            foreach (string dir in Directory.GetDirectories(sourDir))
            {
                string desSubDir = Path.Combine(desDir, Path.GetFileName(dir));
                CopyDirectory(dir, desSubDir);
            }
        }
    }
}
