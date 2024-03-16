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
using up1.ComicsStoreDataSetTableAdapters;

namespace up1
{
    /// <summary>
    /// Логика взаимодействия для Authors.xaml
    /// </summary>
    public partial class Authors : Window
    {
        AuthorsTableAdapter authors = new AuthorsTableAdapter();

        public Authors()
        {
            InitializeComponent();
            AuthorsDataGrid.ItemsSource = authors.GetData();

        }


    }
}
