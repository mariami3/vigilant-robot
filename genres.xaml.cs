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
    /// Логика взаимодействия для genres.xaml
    /// </summary>
    public partial class genres : Window
    {
        private ComicsShopEntities context = new ComicsShopEntities();

        public genres()
        {
            InitializeComponent();
            genre.ItemsSource = context.Genres.ToList();

        }

        private void genre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
