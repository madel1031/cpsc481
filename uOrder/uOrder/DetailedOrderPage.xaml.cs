using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for DetailedOrderPage.xaml
    /// </summary>
    public partial class DetailedOrderPage : UserControl
    {
        double price;
        string item;
        MenuPage _menu;

        public DetailedOrderPage(MenuPage menu, String itemTitle, String itemDetails, double price, bool veg, bool wise)
        {
            InitializeComponent();
            this._menu = menu;
            this.item = itemTitle;
            this.title.Content = itemTitle;
            this.details.Text = itemDetails;
            this.price = price;

            if (veg)
                iconveg.Visibility = Visibility.Visible;
            if (wise)
                iconoceanwise.Visibility = Visibility.Visible;
        }

        //When add to order is pressed
        //Brings item over to item stack 
        public void Button_Click(object sender, RoutedEventArgs e)
        {

            TextBlock one = new TextBlock();
            one.Text = item;
            one.FontSize = 22;
            TextBlock two = new TextBlock();
            if (notes.Text != "Enter preferences or allergies here")
                two.Text = notes.Text;
            two.FontStyle = FontStyles.Italic;
            two.FontSize = 18;
            TextBlock three = new TextBlock();
            three.Text = "$" + price;
            three.FontSize = 18;
            _menu.order_stack.Children.Add(one);
            _menu.order_stack.Children.Add(two);
            _menu.order_stack.Children.Add(three);
            _menu.subtotal += price;
            _menu.gst = Math.Truncate((_menu.subtotal * 0.05)*100) / 100;
            _menu.total = _menu.subtotal + _menu.gst;
            _menu.sub_label.Content = "Subtotal: $" + _menu.subtotal.ToString("F");
            _menu.gst_label.Content = "GST: $" + _menu.gst;
            _menu.tot_label.Content = "Total: $" + _menu.total;
            AutoClosingMessageBox.Show("Added item to order", "Item Added", 500);


        }

        //Go back 
        //Brings back main menu, gets rid of detailed ordered page for item 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _menu.menu.Visibility = Visibility.Visible;
            _menu.page_viewer.Children.Remove(this);
        }

        //Clears text in textbox when writing into it 
        private void notes_GotFocus(object sender, RoutedEventArgs e)
        {
            notes.Clear();
            //keyboard image... 
         
        }
    }
}
