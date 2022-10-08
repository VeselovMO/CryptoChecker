﻿using CryptoChecker.Models;
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
namespace CryptoChecker.Views
{
    /// <summary>
    /// Логика взаимодействия для CurrencyDetails.xaml
    /// </summary>
    public partial class CurrencyDetails : Page
    {
        Currency _item;
        public CurrencyDetails(Currency item)
        {
            _item = item;
            InitializeComponent();
            DataContext = item;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sInfo = new System.Diagnostics.ProcessStartInfo(_item.Explorer)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }
    }
}
