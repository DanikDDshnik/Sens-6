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

        string[] chanellName = new string[6];
        bool StandartNameChanell_1 = true;
        bool StandartNameChanell_2 = true;
        bool StandartNameChanell_3 = true;
        bool StandartNameChanell_4 = true;
        bool StandartNameChanell_5 = true;
        bool StandartNameChanell_6 = true;


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

            Settings.TestTube1 = TestTube1.IsChecked ?? false;
            Settings.TestTube2 = TestTube2.IsChecked ?? false;
            Settings.TestTube3 = TestTube3.IsChecked ?? false;
            Settings.TestTube4 = TestTube4.IsChecked ?? false;
            Settings.TestTube5 = TestTube5.IsChecked ?? false;
            Settings.TestTube6 = TestTube6.IsChecked ?? false;
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

            Settings.TestTube1 = TestTube1.IsChecked ?? false;
            Settings.TestTube2 = TestTube2.IsChecked ?? false;
            Settings.TestTube3 = TestTube3.IsChecked ?? false;
            Settings.TestTube4 = TestTube4.IsChecked ?? false;
            Settings.TestTube5 = TestTube5.IsChecked ?? false;
            Settings.TestTube6 = TestTube6.IsChecked ?? false;
        }


        void TextBox6_TextChanged(object sender, RoutedEventArgs e)
        {
            chanellName[5] = GetDataName6.Text;
            Settings.chanellName[5] = chanellName[5];
            StandartNameChanell_6 = true;
            Settings.StandartNameChanell_6 = StandartNameChanell_6;
        }
        void TextBox5_TextChanged(object sender, RoutedEventArgs e)
        {
            chanellName[4] = GetDataName5.Text;
            Settings.chanellName[4] = chanellName[4];
            StandartNameChanell_5 = true;
            Settings.StandartNameChanell_5 = StandartNameChanell_5;
        }
        void TextBox4_TextChanged(object sender, RoutedEventArgs e)
        {
            chanellName[3] = GetDataName4.Text;
            Settings.chanellName[3] = chanellName[3];
            StandartNameChanell_4 = true;
            Settings.StandartNameChanell_4 = StandartNameChanell_4;
        }
        void TextBox3_TextChanged(object sender, RoutedEventArgs e)
        {
            chanellName[2] = GetDataName3.Text;
            Settings.chanellName[2] = chanellName[2];
            StandartNameChanell_3 = true;
            Settings.StandartNameChanell_3 = StandartNameChanell_3;
        }
        void TextBox2_TextChanged(object sender, RoutedEventArgs e)
        {
            chanellName[1] = GetDataName2.Text;
            Settings.chanellName[1] = chanellName[1];
            StandartNameChanell_2 = true;
            Settings.StandartNameChanell_2 = StandartNameChanell_2;
        }
        void TextBox1_TextChanged(object sender, RoutedEventArgs e)
        {
            chanellName[0] = GetDataName1.Text;
            Settings.chanellName[0] = chanellName[0];
            StandartNameChanell_1 = true;
            Settings.StandartNameChanell_1 = StandartNameChanell_1;
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
    }

}