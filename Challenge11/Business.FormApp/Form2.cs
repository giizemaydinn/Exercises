using Business.Base;
using Business.DummyData;

namespace Business.FormApp
{
    public partial class Form2 : Form
    {
        public int addressId;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserAddressDataAccess.EditAddress(addressId, txtAddress.Text,
                (int)cmbCountry.SelectedValue,
                (int)cmbCity.SelectedValue,
                txtPostalCode.Text, txtLine1.Text, txtLine2.Text);
            this.Hide();
        }

        private void btnEditTelephone_Click(object sender, EventArgs e)
        {
        }

        private void cmbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPhoneType.Items.AddRange(Enum.GetNames(typeof(PhoneType)));
            // cmbPhoneType.SelectedValue = cmbPhones.SelectedValue
            var phone = UserAddressDataAccess.GetPhoneById((int)cmbPhones.SelectedValue);
            if (phone != null)
            {
                txtPhoneName.Text = phone.Name;
                txtPhoneNumber.Text = phone.PhoneNumber;
                cmbPhones.DataSource = Enum.GetValues(typeof(PhoneType));
                //UserAddressDataAccess.EditPhone((int)cmbPhones.SelectedValue, txtPhoneName.Text, txtPhoneNumber.Text, (PhoneType)cmbPhoneType.SelectedValue);

            }
        }
    }
}
