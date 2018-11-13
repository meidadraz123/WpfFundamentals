﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Globalization;

namespace CreatingBindingInCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Equivalent to:
            // Text = "{Binding Path=CurrentCulture, Source={x:Static t:Thread.CurrentThread}}"

            var binding = new Binding(nameof(CultureInfo.CurrentCulture))
            {
                Source = Thread.CurrentThread
            };
            CsBindindData.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
