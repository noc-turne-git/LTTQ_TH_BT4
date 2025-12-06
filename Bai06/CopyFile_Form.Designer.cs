namespace Bai06
{
    partial class CopyFile_Form
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
            components = new System.ComponentModel.Container();
            grpBoxProcess = new GroupBox();
            proBarCopy = new ProgressBar();
            lblSour = new Label();
            grpBoxCopyFile = new GroupBox();
            btnCopy = new Button();
            btnFileDes = new Button();
            txtDes = new TextBox();
            btnFileSour = new Button();
            txtSour = new TextBox();
            lblDes = new Label();
            toolTip = new ToolTip(components);
            grpBoxProcess.SuspendLayout();
            grpBoxCopyFile.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxProcess
            // 
            grpBoxProcess.Controls.Add(proBarCopy);
            grpBoxProcess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxProcess.ForeColor = SystemColors.HotTrack;
            grpBoxProcess.Location = new Point(12, 265);
            grpBoxProcess.Name = "grpBoxProcess";
            grpBoxProcess.Size = new Size(776, 104);
            grpBoxProcess.TabIndex = 1;
            grpBoxProcess.TabStop = false;
            grpBoxProcess.Text = "Tiến trình sao chép";
            // 
            // proBarCopy
            // 
            proBarCopy.Location = new Point(49, 36);
            proBarCopy.Name = "proBarCopy";
            proBarCopy.Size = new Size(708, 39);
            proBarCopy.TabIndex = 0;
            // 
            // lblSour
            // 
            lblSour.AutoSize = true;
            lblSour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSour.ForeColor = SystemColors.Desktop;
            lblSour.Location = new Point(49, 64);
            lblSour.Name = "lblSour";
            lblSour.Size = new Size(196, 20);
            lblSour.TabIndex = 0;
            lblSour.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // grpBoxCopyFile
            // 
            grpBoxCopyFile.Controls.Add(btnCopy);
            grpBoxCopyFile.Controls.Add(btnFileDes);
            grpBoxCopyFile.Controls.Add(txtDes);
            grpBoxCopyFile.Controls.Add(btnFileSour);
            grpBoxCopyFile.Controls.Add(txtSour);
            grpBoxCopyFile.Controls.Add(lblDes);
            grpBoxCopyFile.Controls.Add(lblSour);
            grpBoxCopyFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxCopyFile.ForeColor = SystemColors.HotTrack;
            grpBoxCopyFile.ImeMode = ImeMode.Hiragana;
            grpBoxCopyFile.Location = new Point(12, 26);
            grpBoxCopyFile.Name = "grpBoxCopyFile";
            grpBoxCopyFile.Size = new Size(776, 220);
            grpBoxCopyFile.TabIndex = 0;
            grpBoxCopyFile.TabStop = false;
            grpBoxCopyFile.Text = "Sao chép tập tin";
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.ForeColor = SystemColors.Desktop;
            btnCopy.Location = new Point(268, 164);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(156, 37);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Sao Chép";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnFileDes
            // 
            btnFileDes.AutoSize = true;
            btnFileDes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFileDes.ForeColor = SystemColors.Desktop;
            btnFileDes.Location = new Point(712, 105);
            btnFileDes.Name = "btnFileDes";
            btnFileDes.Size = new Size(45, 30);
            btnFileDes.TabIndex = 5;
            btnFileDes.Text = "...";
            btnFileDes.UseVisualStyleBackColor = true;
            btnFileDes.Click += btnFileDes_Click;
            // 
            // txtDes
            // 
            txtDes.BorderStyle = BorderStyle.FixedSingle;
            txtDes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDes.Location = new Point(251, 108);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(455, 27);
            txtDes.TabIndex = 4;
            // 
            // btnFileSour
            // 
            btnFileSour.AutoSize = true;
            btnFileSour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFileSour.ForeColor = SystemColors.Desktop;
            btnFileSour.Location = new Point(712, 55);
            btnFileSour.Name = "btnFileSour";
            btnFileSour.Size = new Size(45, 30);
            btnFileSour.TabIndex = 3;
            btnFileSour.Text = "...";
            btnFileSour.UseVisualStyleBackColor = true;
            btnFileSour.Click += btnFileSour_Click;
            // 
            // txtSour
            // 
            txtSour.BorderStyle = BorderStyle.FixedSingle;
            txtSour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSour.Location = new Point(251, 57);
            txtSour.Name = "txtSour";
            txtSour.Size = new Size(455, 27);
            txtSour.TabIndex = 2;
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDes.ForeColor = SystemColors.Desktop;
            lblDes.Location = new Point(49, 115);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(181, 20);
            lblDes.TabIndex = 1;
            lblDes.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // CopyFile_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 381);
            Controls.Add(grpBoxProcess);
            Controls.Add(grpBoxCopyFile);
            Name = "CopyFile_Form";
            Text = "Sao chép tập tin";
            grpBoxProcess.ResumeLayout(false);
            grpBoxCopyFile.ResumeLayout(false);
            grpBoxCopyFile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxProcess;
        private Label lblSour;
        private GroupBox grpBoxCopyFile;
        private Button btnCopy;
        private Button btnFileDes;
        private TextBox txtDes;
        private Button btnFileSour;
        private TextBox txtSour;
        private Label lblDes;
        private ProgressBar proBarCopy;
        private ToolTip toolTip;
    }
}
