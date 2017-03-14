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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuPage _menu = new MenuPage();
        ReceiptPage _receipt = new ReceiptPage();
        HelpPage _help = new HelpPage();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.DarkRed;
            help.BorderBrush = Brushes.White;
            receipt.BorderBrush = Brushes.White;
            call.BorderBrush = Brushes.White;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_menu);
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.White;
            help.BorderBrush = Brushes.DarkRed;
            receipt.BorderBrush = Brushes.White;
            call.BorderBrush = Brushes.White;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_help);

        }

        private void receipt_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.White;
            help.BorderBrush = Brushes.White;
            receipt.BorderBrush = Brushes.DarkRed;
            call.BorderBrush = Brushes.White;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_receipt);
        }

        private void call_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.White;
            help.BorderBrush = Brushes.White;
            receipt.BorderBrush = Brushes.White;
            call.BorderBrush = Brushes.DarkRed;
            if (MessageBox.Show("Do you want to call the waiter?", "Call Waiter", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                MessageBox.Show("The waiter has been called. Please wait.", "Call Waiter");

        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you ready to place your order?", "Place Order", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                MessageBox.Show("Your order has been sent to the kitchen. You can view ordered items under 'View Receipt' or order more items under 'Menu'", "Place Order");
        }
    }
}

