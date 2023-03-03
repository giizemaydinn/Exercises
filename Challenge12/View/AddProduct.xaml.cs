using Challenge12.DataAccess;
using Challenge12.Entities;
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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        ProductDal productDal = new ProductDal();
        CategoryDal categoryDal = new CategoryDal();
        SupplierDal supplierDal = new SupplierDal();
        public AddProduct()
        {
            InitializeComponent();

            this.btnAddProduct.Click += BtnAddProduct_Click;
            FillComboxes();

        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            productDal.Add(new Product
            {
                ProductName = txtProductName.Text,
                SupplierID = Convert.ToInt32(cmbCompanyNameOfSupplier.SelectedValue),
                CategoryID = Convert.ToInt32(cmbCategoryName.SelectedValue),
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice=Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock=Convert.ToInt16(txtUnitsInStock.Text),
                UnitsOnOrder= Convert.ToInt16(txtUnitsOnOrder.Text),
                ReorderLevel= Convert.ToInt16(txtReorderLevel.Text),
                Discontinued=chckDiscountinued.IsChecked
            });

            this.Hide();
        }

        private void FillComboxes()
        {
            this.cmbCategoryName.ItemsSource = categoryDal.GetAll();
            this.cmbCategoryName.DisplayMemberPath = "CategoryName";
            this.cmbCategoryName.SelectedValuePath = "CategoryID";

            this.cmbCompanyNameOfSupplier.ItemsSource = supplierDal.GetAll();
            this.cmbCompanyNameOfSupplier.DisplayMemberPath = "CompanyName";
            this.cmbCompanyNameOfSupplier.SelectedValuePath = "SupplierID";
        }
    }
}
