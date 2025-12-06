namespace BTH4_LuuBichNgan_24521128
{
    public partial class KeyMouseEvent : Form
    {
        public KeyMouseEvent()
        {
            InitializeComponent();
            this.KeyPreview = true; // cho phép nhận thông điệp

            this.MouseClick += mouseClick;
            this.KeyDown += keyDown;
            this.KeyPress += keyPress;

        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            string button = e.Button.ToString();
            int x = e.X;
            int y = e.Y;

            MessageBox.Show($"Mouse: {button}, Tọa độ: ({x}, {y})");
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            int keyCode = e.KeyValue;
            Keys key = e.KeyCode;

            MessageBox.Show($"Key: {key}, KeyCode: {keyCode}");
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int ascii = (int)c;

            MessageBox.Show($"Char: {c}, ASCII: {ascii}");
        }
    }
}
