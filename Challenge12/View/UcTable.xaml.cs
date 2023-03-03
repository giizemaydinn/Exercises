using Challenge12.DataAccess;
using Challenge12.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Challenge12.View
{
    /// <summary>
    /// Interaction logic for UcTable.xaml
    /// </summary>
    public partial class UcTable : UserControl
    {
        ProductDal productDal = new ProductDal();
        CustomerDal customerDal = new CustomerDal();
        OrderDal orderDal = new OrderDal();

        private ObservableCollection<IEntity> entities;

        private int page;
        public UcTable()
        {
            InitializeComponent();

            this.btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (page == 1)
            {
                AddCustomer addCustomer = new AddCustomer();
                addCustomer.ShowDialog();
            }
            else if (page == 2)
            {
                AddProduct addProduct = new AddProduct();
                addProduct.ShowDialog();
                dgDetails.ItemsSource = productDal.GetAllDto();
            }
            else if (page == 3)
            {
                AddOrder addOrder = new AddOrder();
                addOrder.ShowDialog();
                dgDetails.ItemsSource = orderDal.GetAllDto();

            }


        }

        public UcTable(int page) : this()
        {
            this.page = page;
            if(page == 1)
            {
                entities = new ObservableCollection<IEntity>(customerDal.GetAll());

                this.dgDetails.ItemsSource = entities.ToList().Cast<Customer>().ToList();

            }
            else if(page == 2)
            {
                entities = new ObservableCollection<IEntity>(productDal.GetAllDto());
                
                this.dgDetails.ItemsSource= entities.ToList().Cast<ProductDto>().ToList();

            }else if(page==3)
            {
                entities = new ObservableCollection<IEntity>(orderDal.GetAllDto());

                this.dgDetails.ItemsSource = entities.ToList().Cast<OrderDto>().ToList();
            }
        }

    }
}
