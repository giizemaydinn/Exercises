using System.Text.Json;
using System.Xml.Serialization;

namespace Challenge08
{
    public partial class Form1 : Form
    {
        User user = new User("g", "1");
        User user1 = new User("Aydin", "1234");
        string path;
        public static string lblOnayText = "";
        public Form1()
        {
            InitializeComponent();

            user.AddProduct(new Product("Bilgisayar"));
            user.AddProduct(new Product("Telefon"));
            user.AddProduct(new Product("USB"));
            user.AddProduct(new Product("Modem"));
            User.Users.Add(user);
            //User.Users.Add(user1);

            Label label = new Label();
            label.Text = "Deneme";
            label.Left = 200;
            label.Top = 200;
            label.Width = 200;
            label.Height = 200;
            label.Visible = true;
            Controls.Add(label);

            lblOnay.Text = lblOnayText;
            ChangePath(@"C:\Users\Z004PS5Z\Downloads\ConsoleApp1\WinFormsApp5\Product.xml");

        }

        private void ChangePath(string v)
        {
            path = v;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            //object obj = cmbStock.SelectedItem;
            //selectedIndex = Convert.ToInt32(obj);
            //

            //if(cmbStock.)
            //{
            //    MessageBox.Show(cmbStock.SelectedValue.ToString());
            //}


        }

        private void cmbStock_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbStock.Items.Count > 0)
            {
                cmbStock.Items.Clear();

            }
            if (isLogin())
            {
                //foreach (var item in user.Products)
                //{
                //    cmbStock.Items.Add(item.Name);
                //}
                cmbStock.DataSource = user.Products.ToList();
                cmbStock.ValueMember = "Id";
                cmbStock.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Kullanici adi ve sifrenizi girmeden malzeme listesine erisemezsiniz.");

            }
        }

        private bool isLogin()
        {
            if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                foreach (var item in User.Users)
                {
                    if (item.UserName == txtUserName.Text && item.Password == txtPassword.Text)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void Kaydet()
        {
            if (lblOnayText != "")
            {

            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbStock.SelectedValue.ToString());
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (chkJson.Checked)
            {
                foreach (var item in user.Products)
                {
                    if (item.Id == (int)cmbStock.SelectedValue)
                    {
                        string fileName = "Product.json";
                        string jsonString = JsonSerializer.Serialize(item);
                        File.WriteAllText(fileName, jsonString);
                        //MessageBox.Show("Cikti olusturuldu.");
                    }
                }

            }

            if (chkXml.Checked)
            {
                foreach (var item in user.Products)
                {
                    var xmlSerializer = new XmlSerializer(typeof(Product));

                    using (var writer = new StreamWriter(path))
                    {
                        xmlSerializer.Serialize(writer, item);
                    }
                }
            }

        }
    }
}