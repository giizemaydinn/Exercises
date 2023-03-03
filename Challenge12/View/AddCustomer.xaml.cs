using Challenge12.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Challenge12.View
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();

            this.btnAddCustomer.Click += BtnAddCustomer_Click;
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(new Customer
            {
                CompanyName = this.txtCompanyName.Text,
                ContactName = this.txtContactName.Text,
                ContactTitle = this.txtContactTitle.Text,
                Address = this.txtAddress.Text,
                City = this.txtCity.Text,
                Region = this.txtRegion.Text,
                PostalCode = this.txtPostalCode.Text,
                Country = this.txtCountry.Text,
                Phone = this.txtPhone.Text,
                Fax = this.txtFax.Text,
            });

            this.Hide();
        }
    }
}
