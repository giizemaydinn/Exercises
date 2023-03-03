namespace Challenge07
{
    /// <summary>
    /// Login ekrani olusturulacak.
    /// </summary>
    public partial class Form1 : Form
    {
        private List<(string, string)> userList = new List<(string, string)>();

        public Form1()
        {
            InitializeComponent();
            userList.Add(("g", "1"));
            userList.Add(("Gizem1", "1234"));
            userList.Add(("Gizem2", "1234"));
            //Buttons
            button1.Click += Button1_Click;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (isLogin(username, password))
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                label4.Visible = true;
            }

        }

        private bool isLogin(string username, string password)
        {
            foreach (var item in userList)
            {
                if (item.Item1 == username && item.Item2 == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}