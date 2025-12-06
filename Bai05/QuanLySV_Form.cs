using System.Windows.Forms;

namespace Bai05
{
    public partial class QuanLySV_Form : Form
    {
        private ThemSV_Form frmThemSV = null;
        private long SoLuongSV;
        public QuanLySV_Form()
        {
            InitializeComponent();

            this.MaximizeBox = false; // Tắt nút Maximize
        }
        public void AddRow(string mssv, string name, string khoa, float diem)
        {
            SoLuongSV++;
            dtGrid.Rows.Add(SoLuongSV.ToString(), mssv, name, khoa, diem);
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            if (frmThemSV == null || frmThemSV.IsDisposed)
            {
                frmThemSV = new ThemSV_Form(this);
                frmThemSV.Show();
            }
            else
            {
                frmThemSV.BringToFront();
                frmThemSV.Focus();
            }
        }
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tlStrip_BtnAdd_Click(object sender, EventArgs e)
        {
            if (frmThemSV == null || frmThemSV.IsDisposed)
            {
                frmThemSV = new ThemSV_Form(this);
                frmThemSV.Show();                 
            }
            else
            {
                frmThemSV.BringToFront();
                frmThemSV.Focus();
            }
        }
        private void tlStrip_TxtName_TextChanged(object sender, EventArgs e)
        {
            string search = tlStrip_TxtName.Text.Trim().ToLower();

            if (String.IsNullOrEmpty(search)) {
                foreach (DataGridViewRow row in dtGrid.Rows)
                    row.Visible = true;
                return;
            }
            foreach (DataGridViewRow row in dtGrid.Rows)
            {
                //if (row.IsNewRow) continue;
                string studentName = row.Cells[2].Value?.ToString().ToLower() ?? "";

                if (studentName.Contains(search))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
    }
}
