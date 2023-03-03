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

namespace Example17
{
    /// <summary>
    /// ZIndex -> Canvas'taki objelerin ustte gorunme sirasi (1 en alt)
    /// Label - TextBox - Button 
    /// Canvas - StackPanel - WrapPanel(icindeki objeleri ekrana sigdirmaya calisir.) - Grid
    /// ComboBox - ListBox - Expander - Menu - DataGrid - DataTemplate
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.btnGo.Click += BtnGo_Click;
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
