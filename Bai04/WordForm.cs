using System.Windows.Forms.Design;

namespace Bai04
{
    public partial class WordForm : Form
    {
        private Font currentFont = new Font("Tahoma", 14);
        private bool isSaved = false;
        private string currentSavePath = "";
        bool isUpdatingUI = false; // tránh bị đệ quy khi updateFont

        public WordForm()
        {
            InitializeComponent();
            foreach (FontFamily f in FontFamily.Families) toolStripCbFontStyle.Items.Add(f.Name);
            toolStripCbFontStyle.SelectedItem = "Tahoma";
            rtBox.Font = currentFont;
        }

        private void ChangeUI()
        {
            isUpdatingUI = true;

            toolStripBtnBold.Checked = currentFont.Bold;
            toolStripBtnItalic.Checked = currentFont.Italic;
            toolStripBtnUnderline.Checked = currentFont.Underline;

            toolStripCbFontSize.Text = currentFont.Size.ToString();
            toolStripCbFontStyle.Text = currentFont.FontFamily.Name;

            isUpdatingUI = false;
        }

        private void UpdateFont()
        {
            if (isUpdatingUI) return;

            if (string.IsNullOrWhiteSpace(toolStripCbFontStyle.Text)) { return; }
            if (!int.TryParse(toolStripCbFontSize.Text, out int size)) { return; }

            FontStyle fs = FontStyle.Regular;
            if (toolStripBtnBold.Checked) fs |= FontStyle.Bold;
            if (toolStripBtnItalic.Checked) fs |= FontStyle.Italic;
            if (toolStripBtnUnderline.Checked) fs |= FontStyle.Underline;

            try
            {
                currentFont = new Font(toolStripCbFontStyle.Text, size, fs);
                rtBox.SelectionFont = currentFont;
            }
            catch
            {
                MessageBox.Show("Font không tồn tại");
            }
        }


        private void toolStripBtnUnderline_Click(object sender, EventArgs e)
        {
            if (isUpdatingUI) return;
            UpdateFont();
        }

        private void toolStripBtnItalic_Click(object sender, EventArgs e)
        {
            if (isUpdatingUI) return;
            UpdateFont();
        }

        private void toolStripBtnBold_Click(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void toolStripCbFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void toolStripCbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void ToolStripMenuItemFormat_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowEffects = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                currentFont = fd.Font;
                rtBox.Font = currentFont;
                ChangeUI();
            }

        }

        private void OpenSaveFileConfirm()
        {
            DialogResult dr;
            if (!isSaved && !string.IsNullOrEmpty(rtBox.Text))
            {
                dr = MessageBox.Show(
                    "Bạn có muốn lưu lại thay đổi không",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (dr == DialogResult.Yes)
                {
                    SaveFile();
                }
            }
        } 

        private void CreateNewText()
        {
            OpenSaveFileConfirm();
            currentSavePath = "";

            rtBox.Text = "";
            FontStyle fs = FontStyle.Regular;
            
            currentFont = new Font("Tahoma", 14, fs);
            rtBox.Font = currentFont;
            ChangeUI();
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            CreateNewText();
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            CreateNewText();
        }

        private void OpenFile()
        {
            OpenSaveFileConfirm();

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = ".rtf|*.rtf|" + ".txt|*.txt|" + "All files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                {
                    rtBox.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rtBox.Text = File.ReadAllText(ofd.FileName);
                }
                currentSavePath = ofd.FileName;
                isSaved = true;

                //Chỉnh lại currentFont và thay đổi UI
                rtBox.SelectionStart = 0;
                rtBox.SelectionLength = 0;

                if (rtBox.SelectionFont != null)
                {
                    currentFont = rtBox.SelectionFont;
                }
                else
                {
                    currentFont = rtBox.Font;
                }

                ChangeUI();

                ChangeUI();
            }
        }

        private void MenuItemOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveToPath(string path)
        {
            if (Path.GetExtension(path).ToLower() == ".rtf")
            {
                rtBox.SaveFile(path, RichTextBoxStreamType.RichText);
            }
            else
            {
                File.WriteAllText(path, rtBox.Text);
            }
        }

        private void SaveFile()
        {
            isSaved = true;
            // đã lưu 1 lần
            if (!string.IsNullOrEmpty(currentSavePath))
            {
                SaveToPath(currentSavePath);
                return;
            }

            //chưa từng lưu
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = ".rtf|*.rtf|" + ".txt|*.txt|" + "All files|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                currentSavePath = sfd.FileName;
                SaveToPath(sfd.FileName);
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void toolStripBtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            OpenSaveFileConfirm();

            Application.Exit();
        }

        private void rtBox_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }
    }
}
 