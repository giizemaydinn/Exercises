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
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        ProductDal productDal = new ProductDal();
        CategoryDal categoryDal = new CategoryDal();
        SupplierDal supplierDal = new SupplierDal();
        CustomerDal customerDal = new CustomerDal();
        ShipperDal shipperDal = new ShipperDal();
        EmployeeDal employeeDal = new EmployeeDal();
        OrderDal orderDal = new OrderDal();
        public AddOrder()
        {
            InitializeComponent();

            this.btnAddOrder.Click += BtnAddOrder_Click;
            FillComboxes();
        }

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            orderDal.Add(new Order
            {
                CustomerID = cmbCompanyNameofCustomer.SelectedValue.ToString(),
                EmployeeID = Convert.ToInt32(cmbEmployeeName.SelectedValue),
                OrderDate= Convert.ToDateTime(dpOrderDate.Text),
                RequiredDate= Convert.ToDateTime(dpRequiredDate.Text),
                ShippedDate= Convert.ToDateTime(dpShippedDate.Text),
                ShipVia = Convert.ToInt32(txtShipVia.Text),
                Freight = Convert.ToDecimal(txtFreight.Text), 
                ShipName = txtShipName.Text,
                ShipAddress = txtShipAddress.Text,
                ShipCity = txtShipCity.Text,
                ShipRegion = txtShipRegion.Text,
                ShipPostalCode= txtShipPostalCode.Text,
                ShipCountry = txtShipCountry.Text,



            });

            this.Hide();
        }

        private void FillComboxes()
        {
            this.cmbCompanyNameofCustomer.ItemsSource = customerDal.GetAll();
            this.cmbCompanyNameofCustomer.DisplayMemberPath = "CompanyName";
            this.cmbCompanyNameofCustomer.SelectedValuePath = "CustomerID";

            this.cmbEmployeeName.ItemsSource = employeeDal.GetAllFullName();
            this.cmbEmployeeName.DisplayMemberPath = "FullName";
            this.cmbEmployeeName.SelectedValuePath = "EmployeeID";
        }
    }
}
