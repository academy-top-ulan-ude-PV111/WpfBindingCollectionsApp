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

namespace WpfBindingCollectionsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new DataSource();
        }

        private void NonNotifiableCollection_Click(object sender, RoutedEventArgs e)
        {
            ((DataSource)this.DataContext).AddNonNotifiableCollection();
        }

        private void NotifiableCollection_Click(object sender, RoutedEventArgs e)
        {
            ((DataSource)this.DataContext).AddNotifiableCollection();
        }
    }
}
