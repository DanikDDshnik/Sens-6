using System;
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
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay;


namespace Sens_6
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        //private void GetDataName1

        private void TestTubeAll_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (TestTubeAll.IsChecked == true);
            TestTube1.IsChecked = newVal;
            TestTube2.IsChecked = newVal;
            TestTube3.IsChecked = newVal;
            TestTube4.IsChecked = newVal;
            TestTube5.IsChecked = newVal;
            TestTube6.IsChecked = newVal;

            Settings.TestTubeAll = TestTubeAll.IsChecked ?? false;
            Settings.TestTube1 = TestTube1.IsChecked ?? false;
            Settings.TestTube2 = TestTube2.IsChecked ?? false;
            Settings.TestTube3 = TestTube3.IsChecked ?? false;
            Settings.TestTube4 = TestTube4.IsChecked ?? false;
            Settings.TestTube5 = TestTube5.IsChecked ?? false;
            Settings.TestTube6 = TestTube6.IsChecked ?? false;
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

            Settings.TestTubeAll = TestTubeAll.IsChecked ?? false;
            Settings.TestTube1 = TestTube1.IsChecked ?? false;
            Settings.TestTube2 = TestTube2.IsChecked ?? false;
            Settings.TestTube3 = TestTube3.IsChecked ?? false;
            Settings.TestTube4 = TestTube4.IsChecked ?? false;
            Settings.TestTube5 = TestTube5.IsChecked ?? false;
            Settings.TestTube6 = TestTube6.IsChecked ?? false;
        }

        void OpenGraphWindowButton_Click(object sender, RoutedEventArgs e)
        {
            GraphWindow graphWindow = new GraphWindow();
            graphWindow.Show();
        }

        void StartReferenceButton_Click(object sender, RoutedEventArgs e)
        {
            StartReference startReference = new StartReference();
            startReference.Reference();
            MessageBox.Show("Reference Button is clicked");
        }

        void StartTermostatButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Termostat Button is clicked");
        }

        void StartTasertButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tasert Button is clicked");
        }

        void resultButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Result Button is clicked");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}