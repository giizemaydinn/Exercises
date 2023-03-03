namespace Challenge08
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Form1.lblOnayText = txtOnay.Text;
            Hide();
        }
    }
}
