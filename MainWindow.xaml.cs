﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using System.Collections.ObjectModel;


namespace Sens_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void TestTubeAll_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (TestTubeAll.IsChecked == true);
            TestTube1.IsChecked = newVal;
            TestTube2.IsChecked = newVal;
            TestTube3.IsChecked = newVal;
            TestTube4.IsChecked = newVal;
            TestTube5.IsChecked = newVal;
            TestTube6.IsChecked = newVal;
        }

        private void TestTube_Checked(object sender, RoutedEventArgs e)
        {
            TestTubeAll.IsChecked = null;
            if ((TestTube1.IsChecked == true) &&
                (TestTube2.IsChecked == true) &&
                (TestTube3.IsChecked == true) &&
                (TestTube4.IsChecked == true) &&
                (TestTube5.IsChecked == true) &&
                (TestTube6.IsChecked == true))
                TestTubeAll.IsChecked = true;

            if ((TestTube1.IsChecked == false) &&
                (TestTube2.IsChecked == false) &&
                (TestTube3.IsChecked == false) &&
                (TestTube4.IsChecked == false) &&
                (TestTube5.IsChecked == false) &&
                (TestTube6.IsChecked == false))
                TestTubeAll.IsChecked = false;
        }


        void OpenGraphWindowButton_Click(object sender, RoutedEventArgs e)
        {
            GraphWindow graphWindow = new GraphWindow();
            graphWindow.Show();
        }
        void StartReferenceButton_Click(object sender, RoutedEventArgs e)
        {
            
        }


    }
}
