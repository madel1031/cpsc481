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

namespace uOrder
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : UserControl
    {
        TunaPokeInAJar _tpiaj = new TunaPokeInAJar();
        public MenuPage()
        {
            InitializeComponent();
        }
        private void order_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you ready to place your order?", "Place Order", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                AutoClosingMessageBox.Show("Your order has been sent to the kitchen. You can view ordered items under 'View Receipt' or order more items under 'Menu'", "Place Order", 2000);
        }
        private void tpiaj_Click(object sender, RoutedEventArgs e)
        {
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_tpiaj);
        }
    }
}
