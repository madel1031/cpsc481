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

namespace View_Receipt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ViewReceipt : Window
    {
        public ViewReceipt()
        {
            InitializeComponent();
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.SandyBrown;
            receipt.BorderBrush = Brushes.White;
            call.BorderBrush = Brushes.White;
            help.BorderBrush = Brushes.White;
        }

        private void receipt_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.White;
            receipt.BorderBrush = Brushes.SandyBrown;
            call.BorderBrush = Brushes.White;
            help.BorderBrush = Brushes.White;
        }



        private void call_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.White;
            receipt.BorderBrush = Brushes.White;
            call.BorderBrush = Brushes.SandyBrown;
            help.BorderBrush = Brushes.White;
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            menu.BorderBrush = Brushes.White;
            receipt.BorderBrush = Brushes.White;
            call.BorderBrush = Brushes.White;
            help.BorderBrush = Brushes.SandyBrown;
        }

        private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
