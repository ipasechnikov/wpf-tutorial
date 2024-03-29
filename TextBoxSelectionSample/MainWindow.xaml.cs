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

namespace TextBoxSelectionSample
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

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)sender;
            txtStatus.Text = $"Selection starts at character #{textBox.SelectionStart}{Environment.NewLine}";
            txtStatus.Text += $"Selection is {textBox.SelectionLength} character(s) long{Environment.NewLine}";
            txtStatus.Text += $"Selection text: '{textBox.SelectedText}'";
        }
    }
}
