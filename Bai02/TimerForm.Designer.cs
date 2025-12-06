namespace Bai02
{
    partial class TimerForm
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
            lblDateTime = new Label();
            SuspendLayout();
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 12F);
            lblDateTime.Location = new Point(269, 206);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(53, 28);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "Start";
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDateTime);
            Name = "TimerForm";
            Text = "TimeShow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDateTime;
    }
}
