using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class ThemSV_Form : Form
    {
        private QuanLySV_Form QLSV_form;
        public ThemSV_Form(QuanLySV_Form form)
        {
            InitializeComponent();
            QLSV_form = form;
            this.MaximizeBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMSSV.Text) || String.IsNullOrEmpty(cbKhoa.Text)
                || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            string mssv = txtMSSV.Text.ToString();
            string khoa = cbKhoa.Text.ToString();
            string name = txtName.Text.ToString();
            float diem;
            if (float.TryParse(txtDiemTB.Text, out float Diem))
            {
                if (Diem < 0 || Diem > 10)
                {
                    MessageBox.Show("Vui lòng nhập số từ 0 đến 10 vào ô Điểm TB");
                    return;
                }
                diem = Diem;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số thực vào ô Điểm TB!");
                return;
            }

            QLSV_form.AddRow(mssv, name, khoa, diem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn trở lại trang Quản Lí Sinh Viên?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
