using System.Windows.Forms;

namespace Bai03
{
    public partial class FormMediaPlay : Form
    {
        System.Windows.Forms.Timer timer;
        public FormMediaPlay()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text =
                $"Hôm nay là ngày {DateTime.Now.ToString("dd/MM/yyyy")} " +
                $"Bây giờ là {DateTime.Now.ToString("hh:mm:ss tt")}";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";

            ofd.Filter = "All Files|*.*|" + "avi|*.avi|" + "mpg|*.mpg|" + "wav|*.wav|" + "midi|*.mid;*.midi|" + "mp4|*.mp4|" + "mp3|*.mp3";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer.URL = ofd.FileName;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn thoát không",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
