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

namespace Challenge12
{
    /// <summary>
    /// Interaction logic for LoginWin.xaml
    /// </summary>
    public partial class LoginWin : Window
    {
        EmployeeDal employeeDal = new EmployeeDal();
        int EmployeeId;
        public LoginWin()
        {
            InitializeComponent();

            this.btnLogin.Click += BtnLogin_Click;
            //this.cmbPerson.ItemsSource 
            this.txtName.TextChanged += TxtName_TextChanged;
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.lblName.Visibility= Visibility.Collapsed;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            EmployeeId = employeeDal.Get(x => x.FirstName == txtName.Text && x.LastName == txtPassword.Password).EmployeeID;
            if (EmployeeId != 0)
            {
                this.Visibility = Visibility.Collapsed;
                MainWindow mainWindow = new MainWindow(EmployeeId);
                mainWindow.Show();
            }

        }
    }
}
