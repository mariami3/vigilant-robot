using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace PY1
{
    /// <summary>
    /// Логика взаимодействия для delevery.xaml
    /// </summary>
    public partial class delevery : Window
    {
        private ComicsShopEntities context = new ComicsShopEntities();

        public delevery()
        {
            InitializeComponent();
            Delevery.ItemsSource = context.Delevery.ToList();

        }


        private void Delevery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
