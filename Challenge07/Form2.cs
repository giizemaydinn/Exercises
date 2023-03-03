namespace Challenge07
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += Form1_Load;

            label1.Text = "Ana Ekran";
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
        }

    }
}
