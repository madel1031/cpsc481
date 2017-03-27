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
    /// 
    public partial class MenuPage : UserControl
    {
        public double subtotal = 0.0;
        public double gst = 0.0;
        public double total = 0.0;

        ReceiptPage _receipt;
        //DetailedOrderPage _detail;

        public MenuPage()
        {
            InitializeComponent();
        }  

        public MenuPage(ReceiptPage receipt, DetailedOrderPage detail)
        {
            InitializeComponent();
            this._receipt = receipt;
            //this._detail = detail;
        }

        

        //PLACE ORDER 
        public void order_Click(object sender, RoutedEventArgs e)
        {
            Button add = (Button)sender;
            //DetailedOrderPage.Button_Click();


            if (MessageBox.Show("Are you ready to place your order?", "Place Order", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                

                AutoClosingMessageBox.Show("Your order has been sent to the kitchen. You can view ordered items under 'View Receipt' or order more items under 'Menu'", "Place Order", 2500);
           
            }

        }
        private void tpiaj_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Tuna Poke in a Jar", "avocado, fresh tomatoes, nori crisps, ginger, spring onions + ponzu - 9 ¾", 9.75, false, true));
           
        }
        private void kfc_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Korean Fried Cauliflower", "spicy gochujang pepper sauce, jalapeno lime dip - 9 ¾", 9.75, false, false));
        }
        private void c_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Calamari", "+ tempura prawns, sriracha aioli + sweet chili sauce - 13 ¾", 13.75, false, false));
        }
        private void b_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Bruschetta", "9 ¾", 9.75, true, false));
        }
        private void ps_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Pot-Stickers", "12 ¾", 12.75, false, false));
        }
        private void mb_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Med-Bread", "fresh baked flatbread, three dips - 9 ¾", 9.75, true, false));
        }
        private void dr_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Dry Ribs", "11 ¾", 11.75, false,false));
        }
        private void sc_Click(object sender, RoutedEventArgs e)
        {
            /**
            //menu.Visibility = Visibility.Collapsed;
            //page_viewer.Children.Add(new DetailedOrderPage(this, "Sushi Cones", "tempura prawns, fresh avocado, nori + ponzu - 14 ¼", 14.25, false, false));
            Label unavailable = new Label();
            unavailable.Content = "We're sorry, this item is currently unavailable.";
            unavailable.FontSize = 20;
            //textbox.Background = Brushes.White;
            //unavailable.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            unavailable.FontFamily = new FontFamily("DengXian");
            unavailable.HorizontalContentAlignment = HorizontalAlignment.Center;
            unavailable.VerticalContentAlignment = VerticalAlignment.Center;
            unavailable.Height = 80;
            unavailable.Width = 735;
            no.Children.Clear();
            no.Children.Add(unavailable);
            */
        }

        private void icf_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Indo Chicken Flatbread", "served open faced, pulled chicken, refried beans, shredded cheese,  \n crispy lentils on curry naan. - 9 ¾", 9.75, false, false));
        }
        private void md_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Mosaic Dip", "goat cheese, mushrooms, fresh baked flatbread - 14 ¾", 14.75, true, false));
        }
        private void scc_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Sweet Chili Chicken", "12 ¾", 12.75, false, false));
        }
        private void cw_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Chicken Wings", "biryani, salt & pepper, honey garlic, hot - 13 ½", 13.5, false, false));
        }
        private void lw_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Lettuce Wraps", "fresh veggies, cashews, chow mein noodles, ginger soy glaze - 13 ¾ \n add chicken - 5", 13.75, false, false));
        }
        private void dcnsp_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Double Cheese Nachos Share Platter", "19 ¾ \n add beef - 5 \n add pulled chicken - 5", 19.75, false, false));
        }
        private void dcn12_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            page_viewer.Children.Add(new DetailedOrderPage(this, "Double Cheese Nachos for One or Two", "13 ¾ \n add beef - 5 \n add pulled chicken - 5", 13.75, false, false));
        }

    }
}
