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

namespace CollegeApplication
{
    /// <summary>
    /// Логика взаимодействия для PageMenuStudent.xaml
    /// </summary>
    public partial class PageMenuStudent : ContentControl
    {
        public PageMenuStudent()
        {
            InitializeComponent();
        }

        private void BtnShedule_OnClick(object sender, RoutedEventArgs e)
        {
            ClassFrame.frameContent.Content = new Schedule();
        }
    }
}
