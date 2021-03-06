﻿using System;
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
    /// Interaction logic for OrderItem.xaml
    /// </summary>
    public partial class ReceiptItem : UserControl
    {
        String title;
        String details;
        double price;
        public ReceiptItem(String title, String details, double price, bool refillable)
        {
            InitializeComponent();
            this.title = title;
            this.details = details;
            this.price = price;
            if (refillable)
                refill.Visibility = Visibility.Visible;
            this.item_title.Content = title;
            this.item_details.Text = details;
            this.item_price.Content = price.ToString("F");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AutoClosingMessageBox.Show("Your refill is on its way", "Refill", 1500);

        }
    }
}
