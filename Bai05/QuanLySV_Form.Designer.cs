namespace Bai05
{
    partial class QuanLySV_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySV_Form));
            menuStrip = new MenuStrip();
            ToolStripChucNang = new ToolStripMenuItem();
            MenuItemAdd = new ToolStripMenuItem();
            MenuItemExit = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tlStrip_BtnAdd = new ToolStripButton();
            tlStripFind = new ToolStripTextBox();
            tlStrip_TxtName = new ToolStripTextBox();
            dtGrid = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colMSSV = new DataGridViewTextBoxColumn();
            colTSV = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewTextBoxColumn();
            colDiemTB = new DataGridViewTextBoxColumn();
            menuStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { ToolStripChucNang });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(821, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "Menu";
            // 
            // ToolStripChucNang
            // 
            ToolStripChucNang.DropDownItems.AddRange(new ToolStripItem[] { MenuItemAdd, MenuItemExit });
            ToolStripChucNang.Name = "ToolStripChucNang";
            ToolStripChucNang.Size = new Size(96, 24);
            ToolStripChucNang.Text = "Chức Năng";
            // 
            // MenuItemAdd
            // 
            MenuItemAdd.Name = "MenuItemAdd";
            MenuItemAdd.ShortcutKeys = Keys.Control | Keys.N;
            MenuItemAdd.Size = new Size(212, 26);
            MenuItemAdd.Text = "Thêm Mới";
            MenuItemAdd.Click += MenuItemAdd_Click;
            // 
            // MenuItemExit
            // 
            MenuItemExit.Name = "MenuItemExit";
            MenuItemExit.Size = new Size(212, 26);
            MenuItemExit.Text = "Thoát";
            MenuItemExit.Click += MenuItemExit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.AutoSize = false;
            toolStrip1.CanOverflow = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tlStrip_BtnAdd, tlStripFind, tlStrip_TxtName });
            toolStrip1.Location = new Point(9, 34);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(803, 50);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tlStrip_BtnAdd
            // 
            tlStrip_BtnAdd.AutoSize = false;
            tlStrip_BtnAdd.AutoToolTip = false;
            tlStrip_BtnAdd.Image = (Image)resources.GetObject("tlStrip_BtnAdd.Image");
            tlStrip_BtnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            tlStrip_BtnAdd.ImageScaling = ToolStripItemImageScaling.None;
            tlStrip_BtnAdd.ImageTransparentColor = Color.Magenta;
            tlStrip_BtnAdd.Name = "tlStrip_BtnAdd";
            tlStrip_BtnAdd.Size = new Size(300, 50);
            tlStrip_BtnAdd.Text = "Thêm Mới";
            tlStrip_BtnAdd.TextAlign = ContentAlignment.MiddleLeft;
            tlStrip_BtnAdd.Click += tlStrip_BtnAdd_Click;
            // 
            // tlStripFind
            // 
            tlStripFind.Name = "tlStripFind";
            tlStripFind.Size = new Size(150, 50);
            tlStripFind.Text = "Tìm Kiếm Theo Tên";
            // 
            // tlStrip_TxtName
            // 
            tlStrip_TxtName.BackColor = Color.White;
            tlStrip_TxtName.BorderStyle = BorderStyle.FixedSingle;
            tlStrip_TxtName.Name = "tlStrip_TxtName";
            tlStrip_TxtName.Size = new Size(330, 50);
            tlStrip_TxtName.TextChanged += tlStrip_TxtName_TextChanged;
            // 
            // dtGrid
            // 
            dtGrid.AllowUserToAddRows = false;
            dtGrid.AllowUserToResizeColumns = false;
            dtGrid.Anchor = AnchorStyles.Bottom;
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Columns.AddRange(new DataGridViewColumn[] { colSTT, colMSSV, colTSV, colKhoa, colDiemTB });
            dtGrid.Location = new Point(0, 91);
            dtGrid.Name = "dtGrid";
            dtGrid.ReadOnly = true;
            dtGrid.RowHeadersWidth = 51;
            dtGrid.Size = new Size(821, 385);
            dtGrid.TabIndex = 2;
            // 
            // colSTT
            // 
            colSTT.HeaderText = "Số TT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 125;
            // 
            // colMSSV
            // 
            colMSSV.HeaderText = "Mã Số SV";
            colMSSV.MinimumWidth = 6;
            colMSSV.Name = "colMSSV";
            colMSSV.ReadOnly = true;
            colMSSV.Width = 125;
            // 
            // colTSV
            // 
            colTSV.HeaderText = "Tân Sinh Viên";
            colTSV.MinimumWidth = 6;
            colTSV.Name = "colTSV";
            colTSV.ReadOnly = true;
            colTSV.Width = 125;
            // 
            // colKhoa
            // 
            colKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKhoa.FillWeight = 120F;
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 6;
            colKhoa.Name = "colKhoa";
            colKhoa.ReadOnly = true;
            // 
            // colDiemTB
            // 
            colDiemTB.HeaderText = "Điểm TB";
            colDiemTB.MinimumWidth = 6;
            colDiemTB.Name = "colDiemTB";
            colDiemTB.ReadOnly = true;
            colDiemTB.Width = 125;
            // 
            // QuanLySV_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 449);
            Controls.Add(dtGrid);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip);
            Name = "QuanLySV_Form";
            Text = "Quản Lý Sinh Vien";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStrip toolStrip1;
        private ToolStripButton tlStrip_BtnAdd;
        private ToolStripTextBox tlStripFind;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMSSV;
        private DataGridViewTextBoxColumn colTSV;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colDiemTB;
        private ToolStripTextBox tlStrip_TxtName;
        public DataGridView dtGrid;
        private ToolStripMenuItem ToolStripChucNang;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemExit;
    }
}
