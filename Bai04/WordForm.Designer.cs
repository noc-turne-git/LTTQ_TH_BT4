namespace Bai04
{
    partial class WordForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="
        /// posing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordForm));
            //ToolStripButton toolStripBtnBold;
            menuStrip = new MenuStrip();
            ToolStripMenuItemSystem = new ToolStripMenuItem();
            MenuItemNew = new ToolStripMenuItem();
            MenuItemOpenFile = new ToolStripMenuItem();
            MenuItemSave = new ToolStripMenuItem();
            MenuItemExit = new ToolStripMenuItem();
            ToolStripMenuItemFormat = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripBtnSaveFile = new ToolStripButton();
            toolStripCbFontStyle = new ToolStripComboBox();
            toolStripCbFontSize = new ToolStripComboBox();
            toolStripBtnItalic = new ToolStripButton();
            toolStripBtnUnderline = new ToolStripButton();
            rtBox = new RichTextBox();
            panel = new Panel();
            toolStripBtnBold = new ToolStripButton();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ActiveCaption;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemSystem, ToolStripMenuItemFormat });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(335, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemSystem
            // 
            ToolStripMenuItemSystem.DropDownItems.AddRange(new ToolStripItem[] { MenuItemNew, MenuItemOpenFile, MenuItemSave, MenuItemExit });
            ToolStripMenuItemSystem.Name = "ToolStripMenuItemSystem";
            ToolStripMenuItemSystem.Size = new Size(85, 24);
            ToolStripMenuItemSystem.Text = "Hệ thống";
            // 
            // MenuItemNew
            // 
            MenuItemNew.Image = (Image)resources.GetObject("MenuItemNew.Image");
            MenuItemNew.Name = "MenuItemNew";
            MenuItemNew.ShortcutKeys = Keys.Control | Keys.N;
            MenuItemNew.Size = new Size(285, 26);
            MenuItemNew.Text = "Tạo văn bản mới";
            MenuItemNew.TextAlign = ContentAlignment.MiddleLeft;
            MenuItemNew.Click += MenuItemNew_Click;
            // 
            // MenuItemOpenFile
            // 
            MenuItemOpenFile.Image = (Image)resources.GetObject("MenuItemOpenFile.Image");
            MenuItemOpenFile.Name = "MenuItemOpenFile";
            MenuItemOpenFile.Size = new Size(285, 26);
            MenuItemOpenFile.Text = "Mở tập tin";
            MenuItemOpenFile.Click += MenuItemOpenFile_Click;
            // 
            // MenuItemSave
            // 
            MenuItemSave.Image = (Image)resources.GetObject("MenuItemSave.Image");
            MenuItemSave.Name = "MenuItemSave";
            MenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            MenuItemSave.Size = new Size(285, 26);
            MenuItemSave.Text = "Lưu nội dung văn bản";
            MenuItemSave.Click += MenuItemSave_Click;
            // 
            // MenuItemExit
            // 
            MenuItemExit.Name = "MenuItemExit";
            MenuItemExit.Size = new Size(285, 26);
            MenuItemExit.Text = "Thoát";
            MenuItemExit.Click += MenuItemExit_Click;
            // 
            // ToolStripMenuItemFormat
            // 
            ToolStripMenuItemFormat.Name = "ToolStripMenuItemFormat";
            ToolStripMenuItemFormat.Size = new Size(92, 24);
            ToolStripMenuItemFormat.Text = "Định dạng";
            ToolStripMenuItemFormat.Click += ToolStripMenuItemFormat_Click;
            // 
            // toolStrip
            // 
            toolStrip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip.AutoSize = false;
            toolStrip.BackColor = SystemColors.ActiveCaption;
            toolStrip.CanOverflow = false;
            toolStrip.Dock = DockStyle.None;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripBtnNew, toolStripBtnSaveFile, toolStripCbFontStyle, toolStripCbFontSize, toolStripBtnBold, toolStripBtnItalic, toolStripBtnUnderline });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(404, 28);
            toolStrip.Stretch = true;
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripBtnNew
            // 
            toolStripBtnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnNew.Image = (Image)resources.GetObject("toolStripBtnNew.Image");
            toolStripBtnNew.ImageTransparentColor = Color.Magenta;
            toolStripBtnNew.Name = "toolStripBtnNew";
            toolStripBtnNew.Size = new Size(29, 25);
            toolStripBtnNew.ToolTipText = "Tạo văn bản mới";
            toolStripBtnNew.Click += toolStripBtnNew_Click;
            // 
            // toolStripBtnSaveFile
            // 
            toolStripBtnSaveFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnSaveFile.Image = (Image)resources.GetObject("toolStripBtnSaveFile.Image");
            toolStripBtnSaveFile.ImageTransparentColor = Color.Magenta;
            toolStripBtnSaveFile.Name = "toolStripBtnSaveFile";
            toolStripBtnSaveFile.Size = new Size(29, 25);
            toolStripBtnSaveFile.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolStripBtnSaveFile.ToolTipText = "Lưu nội dung văn bản";
            toolStripBtnSaveFile.Click += toolStripBtnSaveFile_Click;
            // 
            // toolStripCbFontStyle
            // 
            toolStripCbFontStyle.Name = "toolStripCbFontStyle";
            toolStripCbFontStyle.Size = new Size(121, 28);
            toolStripCbFontStyle.ToolTipText = "Kiểu chữ";
            toolStripCbFontStyle.SelectedIndexChanged += toolStripCbFontStyle_SelectedIndexChanged;
            // 
            // toolStripCbFontSize
            // 
            toolStripCbFontSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            toolStripCbFontSize.Name = "toolStripCbFontSize";
            toolStripCbFontSize.Size = new Size(121, 28);
            toolStripCbFontSize.SelectedItem = "14";
            toolStripCbFontSize.ToolTipText = "Cỡ chữ";
            toolStripCbFontSize.SelectedIndexChanged += toolStripCbFontSize_SelectedIndexChanged;
            // 
            //
            // 
            // 
            toolStripBtnBold.AutoSize = false;
            toolStripBtnBold.BackColor = SystemColors.ActiveCaption;
            toolStripBtnBold.BackgroundImageLayout = ImageLayout.None;
            toolStripBtnBold.CheckOnClick = true;
            toolStripBtnBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripBtnBold.ForeColor = SystemColors.ControlText;
            toolStripBtnBold.ImageTransparentColor = Color.Magenta;
            toolStripBtnBold.Name = "toolStripBtnBold";
            toolStripBtnBold.Size = new Size(29, 25);
            toolStripBtnBold.Text = "B";
            toolStripBtnBold.ToolTipText = "In đậm";
            toolStripBtnBold.Click += toolStripBtnBold_Click;
            // 
            // toolStripBtnItalic
            // 
            toolStripBtnItalic.AutoSize = false;
            toolStripBtnItalic.BackColor = SystemColors.ActiveCaption;
            toolStripBtnItalic.CheckOnClick = true;
            toolStripBtnItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripBtnItalic.ImageTransparentColor = Color.Magenta;
            toolStripBtnItalic.Name = "toolStripBtnItalic";
            toolStripBtnItalic.Size = new Size(29, 25);
            toolStripBtnItalic.Text = "I";
            toolStripBtnItalic.ToolTipText = "In Nghiêng";
            toolStripBtnItalic.Click += toolStripBtnItalic_Click;
            // 
            // toolStripBtnUnderline
            // 
            toolStripBtnUnderline.AutoSize = false;
            toolStripBtnUnderline.BackColor = SystemColors.ActiveCaption;
            toolStripBtnUnderline.CheckOnClick = true;
            toolStripBtnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            toolStripBtnUnderline.Image = (Image)resources.GetObject("toolStripBtnUnderline.Image");
            toolStripBtnUnderline.ImageTransparentColor = Color.Magenta;
            toolStripBtnUnderline.Name = "toolStripBtnUnderline";
            toolStripBtnUnderline.Size = new Size(29, 25);
            toolStripBtnUnderline.Text = "U";
            toolStripBtnUnderline.ToolTipText = "Gạch chân";
            toolStripBtnUnderline.Click += toolStripBtnUnderline_Click;
            // 
            // rtBox
            // 
            rtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtBox.BorderStyle = BorderStyle.FixedSingle;
            rtBox.Location = new Point(0, 57);
            rtBox.Name = "rtBox";
            rtBox.Size = new Size(800, 393);
            rtBox.TabIndex = 2;
            rtBox.Text = "";
            rtBox.TextChanged += rtBox_TextChanged;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Controls.Add(menuStrip);
            panel.Controls.Add(toolStrip);
            panel.Location = new Point(0, 1);
            panel.Name = "panel";
            panel.Size = new Size(800, 56);
            panel.TabIndex = 0;
            // 
            // WordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(rtBox);
            MainMenuStrip = menuStrip;
            Name = "WordForm";
            Text = "Soạn thảo văn bản";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem ToolStripMenuItemSystem;
        private ToolStripMenuItem MenuItemNew;
        private ToolStripMenuItem MenuItemOpenFile;
        private ToolStripMenuItem MenuItemSave;
        private ToolStripMenuItem MenuItemExit;
        private ToolStripMenuItem ToolStripMenuItemFormat;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripBtnNew;
        private ToolStripButton toolStripBtnSaveFile;
        private ToolStripComboBox toolStripCbFontStyle;
        private ToolStripComboBox toolStripCbFontSize;
        private ToolStripButton toolStripBtnBold;
        private ToolStripButton toolStripBtnItalic;
        private ToolStripButton toolStripBtnUnderline;
        private RichTextBox rtBox;
        private Panel panel;
    }
}
