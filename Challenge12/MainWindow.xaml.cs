using Challenge12.DataAccess;
using Challenge12.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Challenge12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            this.btnOrder.Click += BtnOrder_Click;
            this.btnHome.Click += BtnHome_Click;
            this.btnProduct.Click += BtnProduct_Click;
            this.btnCustomer.Click += BtnCustomer_Click;

        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            GetPage(1);
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            GetPage(2);
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            if (grGetContent.Children.Count > 0)
            {
                grGetContent.Children.RemoveAt(0);
            }
            Home home = new Home(); 
            grGetContent.Children.Add(home);
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            GetPage(3);
        }

        private void GetPage(int page)
        {
            if(grGetContent.Children.Count > 0)
            {
                grGetContent.Children.RemoveAt(0);
            }
            UcTable ucTable = new UcTable(page);
            grGetContent.Children.Add(ucTable);
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
