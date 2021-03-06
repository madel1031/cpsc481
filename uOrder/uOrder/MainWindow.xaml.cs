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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ReceiptPage _receipt = new ReceiptPage();
        MenuPage _menu;
        HelpPage _help = new HelpPage();
        SolidColorBrush darkRed = new SolidColorBrush(Color.FromRgb(79, 13, 13));
        SolidColorBrush white = new SolidColorBrush(Color.FromRgb(238, 230, 228));
        int calls = 0;

        public MainWindow()
        {
            InitializeComponent();
            _menu = new MenuPage(_receipt);
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = white;
            help.BorderBrush = darkRed;
            receipt.BorderBrush = darkRed;
            call.BorderBrush = darkRed;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_menu);
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = darkRed;
            help.BorderBrush = white;
            receipt.BorderBrush = darkRed;
            call.BorderBrush = darkRed;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_help);

        }

        private void receipt_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = darkRed;
            help.BorderBrush = darkRed;
            receipt.BorderBrush = white;
            call.BorderBrush = darkRed;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_receipt);
        }

        private void call_Click(object sender, RoutedEventArgs e)
        {
            Brush menu_brush = menu.BorderBrush;
            Brush help_brush = help.BorderBrush;
            Brush receipt_brush = receipt.BorderBrush;
            menu.BorderBrush = darkRed;
            help.BorderBrush = darkRed;
            receipt.BorderBrush = darkRed;
            call.BorderBrush = white;
            if (MessageBox.Show("Do you want to call the waiter?", "Call Waiter", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (calls == 0)
                {
                    calls++;
                    AutoClosingMessageBox.Show("The waiter has been called. Please wait.", "Waiter Called", 1200);
                }
                else
                    AutoClosingMessageBox.Show("The waiter has been called again. Please wait.", "Waiter Called <" + ++calls + ">", 1200);
            }

            menu.BorderBrush = menu_brush;
            help.BorderBrush = help_brush;
            receipt.BorderBrush = receipt_brush;
            call.BorderBrush = darkRed;

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {

            start.Visibility = Visibility.Hidden;
            menu.BorderBrush = white;
            page_viewer.Children.Clear();
            page_viewer.Children.Add(_menu);
        }
    }
}