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

namespace Sens_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox check1 = (CheckBox)sender;
            CheckBox check2 = (CheckBox)sender;
            CheckBox check3 = (CheckBox)sender;
            CheckBox check4 = (CheckBox)sender;
            CheckBox check5 = (CheckBox)sender;
            CheckBox check6 = (CheckBox)sender;
            CheckBox checkall = (CheckBox)sender;
            if(checkAll.Checked == true)
            {
                MessageBox.Show("");
            }
        }
    }
}
