namespace Bai05
{
    partial class ThemSV_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMSSV = new Label();
            txtMSSV = new TextBox();
            cbKhoa = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            lblDiemTB = new Label();
            lblKhoa = new Label();
            txtDiemTB = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblMSSV
            // 
            lblMSSV.Font = new Font("Segoe UI", 12F);
            lblMSSV.Location = new Point(96, 70);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(160, 35);
            lblMSSV.TabIndex = 0;
            lblMSSV.Text = "Mã Số Sinh Viên";
            lblMSSV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMSSV
            // 
            txtMSSV.BorderStyle = BorderStyle.FixedSingle;
            txtMSSV.Font = new Font("Segoe UI", 12F);
            txtMSSV.Location = new Point(262, 70);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(438, 34);
            txtMSSV.TabIndex = 1;
            // 
            // cbKhoa
            // 
            cbKhoa.Font = new Font("Segoe UI", 12F);
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Kỹ thuật phần mềm", "Khoa học máy tính", "Thương mại điện tử", "An toàn thông tin", "Hệ thống thông tin", "Trí tuệ nhân tạo", "Mạng máy tính và truyền thông" });
            cbKhoa.Location = new Point(262, 210);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(438, 36);
            cbKhoa.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(96, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(163, 35);
            lblName.TabIndex = 3;
            lblName.Text = "Tên Sinh Viên";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(262, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(438, 34);
            txtName.TabIndex = 4;
            // 
            // lblDiemTB
            // 
            lblDiemTB.Font = new Font("Segoe UI", 12F);
            lblDiemTB.Location = new Point(96, 280);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(163, 35);
            lblDiemTB.TabIndex = 5;
            lblDiemTB.Text = "Điểm TB";
            lblDiemTB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKhoa
            // 
            lblKhoa.Font = new Font("Segoe UI", 12F);
            lblKhoa.Location = new Point(96, 210);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(163, 35);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa";
            lblKhoa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiemTB
            // 
            txtDiemTB.BorderStyle = BorderStyle.FixedSingle;
            txtDiemTB.Font = new Font("Segoe UI", 12F);
            txtDiemTB.Location = new Point(262, 280);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(438, 34);
            txtDiemTB.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(450, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 52);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkOrange;
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(628, 354);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 52);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // ThemSV_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(txtDiemTB);
            Controls.Add(lblKhoa);
            Controls.Add(lblDiemTB);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(cbKhoa);
            Controls.Add(txtMSSV);
            Controls.Add(lblMSSV);
            Name = "ThemSV_Form";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSSV;
        private TextBox txtMSSV;
        private ComboBox cbKhoa;
        private Label lblName;
        private TextBox txtName;
        private Label lblDiemTB;
        private Label lblKhoa;
        private TextBox txtDiemTB;
        private Button btnAdd;
        private Button btnExit;
    }
}