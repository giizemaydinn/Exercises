using Challenge12.DataAccess;
using Challenge12.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using static System.Net.Mime.MediaTypeNames;

namespace Challenge12.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        EmployeeDal employeeDal = new EmployeeDal();
        public Home()
        {
            InitializeComponent();

            //BitmapImage imageSource = new BitmapImage();
            //using (var mem = new MemoryStream(employeeDal.Get(x => x.EmployeeID == 1).Photo))
            //{
            //    //mem.Position = 0;
            //    imageSource.BeginInit();
            //    //imageSource.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
            //    //imageSource.CacheOption = BitmapCacheOption.OnLoad;
            //    //imageSource.UriSource = null;
            //    imageSource.StreamSource = mem;
            //    imageSource.CacheOption= BitmapCacheOption.OnLoad;
            //    imageSource.EndInit();
            //}

            //img.Source = imageSource;

        }


    }
    }

