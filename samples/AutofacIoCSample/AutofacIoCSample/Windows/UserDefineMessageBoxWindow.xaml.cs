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
using System.Windows.Shapes;

namespace AutofacIoCSample.Windows
{
    /// <summary>
    /// UserDefineMessageBoxWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserDefineMessageBoxWindow : Window
    {
        public UserDefineMessageBoxWindow()
        {
            InitializeComponent();
        }

        public void SetMsg(string msg)
        {
            MsgTextTextBox.Text = msg;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
