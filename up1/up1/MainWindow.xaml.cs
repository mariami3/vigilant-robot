using System;
using System.Collections.Generic;
using System.Data;
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
using up1.ComicsStoreDataSetTableAdapters;





namespace up1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComicsButton_Click(object sender, RoutedEventArgs e)
        {
            Comics сomicsWindow = new Comics();
            сomicsWindow.ShowDialog();
        }

        private void AuthorsButton_Click(object sender, RoutedEventArgs e)
        {
            Authors authorWindow = new Authors();
            authorWindow.ShowDialog();
        }

        private void GenresButton_Click(object sender, RoutedEventArgs e)
        {
            Genres genresWindow = new Genres();
            genresWindow.ShowDialog();
        }
    }
}


