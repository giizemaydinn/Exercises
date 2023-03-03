using Business.DummyData;

namespace Business.FormApp
{
    public partial class Form1 : Form
    {
        private int selectedId = -1;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            FillDataGridView();
        }

        public void FillDataGridView()
        {
            dgvUsers.DataSource = UserDataAccess.GetAll();
            
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            var user = UserDataAccess.GetById(selectedId);
            if (user != null)
            {
                FillUserFields(user);
            }
        }

        private void FillUserFields(User.User user)
        {
            txtUName.Text = user.Username;
            txtPwd.Text = user.Password;
            txtName.Text = user.Firstname;
            txtLastName.Text = user.Lastname;
            
            
            cmbAddress.DataSource = null;
            cmbAddress.DataSource = user.Addresses;
            cmbAddress.DisplayMember = "Name";
            cmbAddress.ValueMember= "ID";

        }

        private void FillAddressFormFields()
        {
            var useraddress = UserAddressDataAccess.GetById((int)cmbAddress.SelectedValue);
            if (useraddress != null)
            {
                form2.addressId = (int)cmbAddress.SelectedValue;

                form2.txtAddress.Text = useraddress.Name;

                form2.cmbCountry.DataSource = Data.countries;
                form2.cmbCountry.DisplayMember = "Name";
                form2.cmbCountry.ValueMember = "ID";
                form2.cmbCountry.SelectedValue = useraddress.Country.ID;

                form2.cmbCity.DataSource = Data.cities;
                form2.cmbCity.DisplayMember = "Name";
                form2.cmbCity.ValueMember = "ID";
                form2.cmbCity.SelectedValue = useraddress.City.ID;

                form2.txtPostalCode.Text = useraddress.PostalCode;
                form2.txtLine1.Text = useraddress.AddressLine1;
                form2.txtLine2.Text = useraddress.AddressLine2;

                form2.cmbPhones.DataSource = useraddress.Phones;
                form2.cmbPhones.ValueMember= "ID";
                form2.cmbPhones.DisplayMember= "Name";
                //form2.cmbPhones.SelectedValue = useraddress.Phones.FirstOrDefault().ID;
                form2.ShowDialog();

                selectedId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                
                var user = UserDataAccess.GetById(selectedId);
                if (user != null)
                {
                    FillUserFields(user);
                }


            }
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            FillAddressFormFields();
        }
    }
}