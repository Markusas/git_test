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

namespace Git_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            //string name = num1.Text;
            //result.Content = "Hello, " + name;

            int num = int.Parse(num1.Text);
            int squareNumber = num * num;
            result.Content = squareNumber;
        }
    }
}
