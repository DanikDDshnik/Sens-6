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
using System.Collections.ObjectModel;
using Microsoft.Research.DynamicDataDisplay.DataSources;

namespace Sens_6
{
    public partial class GraphWindow : Window
    {

        struct dataChanell
        {
            const int SIZE_VECTOR = 256;

            string name; //  ����� � �������� ������

            int[] aData; // ������ ��������� � �������
            double aTotalCapacity; // ����� �������
            double[] aData_Capacity; // ����� ������
            int[] aData_Frequency; // ������� ������
            int[] aError_Capacity; // ������ �������
            int[] aError_Frequency; // ������ ���������

            bool IsDataValid; // �������� ������

        }

         
        public GraphWindow()
        {
            InitializeComponent();
            Loaded += GraphWindow_Referance;


        }
        
        private void GraphWindow_Referance (object sender, RoutedEventArgs e)
        {

            List<Point> points1 = new List<Point>();
            List<Point> points2 = new List<Point>();
            List<Point> points3 = new List<Point>();
            List<Point> points4 = new List<Point>();
            List<Point> points5 = new List<Point>();
            List<Point> points6 = new List<Point>();

            points1 = Settings.points1;
            points2 = Settings.points2;
            points3 = Settings.points3;
            points4 = Settings.points4;
            points5 = Settings.points5;
            points6 = Settings.points6;

            bool TestTube1 = Settings.TestTube1;
            bool TestTube2 = Settings.TestTube2;
            bool TestTube3 = Settings.TestTube3;
            bool TestTube4 = Settings.TestTube4;
            bool TestTube5 = Settings.TestTube5;
            bool TestTube6 = Settings.TestTube6;

            if (TestTube1 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);
                dataSource.AppendMany(points1);

                // ���������� �������� ������ � �������
                lineGraphReference_1.DataSource = dataSource;
            }

            if (TestTube2 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);
                dataSource.AppendMany(points2);

                // ���������� �������� ������ � �������
                lineGraphReference_2.DataSource = dataSource;
            }

            if (TestTube3 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);
                dataSource.AppendMany(points3);

                // ���������� �������� ������ � �������
                lineGraphReference_3.DataSource = dataSource;
            }

            if (TestTube4 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);
                dataSource.AppendMany(points4);

                // ���������� �������� ������ � �������
                lineGraphReference_4.DataSource = dataSource;
            }


            if (TestTube5 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);
                dataSource.AppendMany(points5);

                // ���������� �������� ������ � �������
                lineGraphReference_5.DataSource = dataSource;
            }

            if (TestTube6 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);
                dataSource.AppendMany(points6);

                // ���������� �������� ������ � �������
                lineGraphReference_6.DataSource = dataSource;
            }



            plotter.Viewport.FitToView();
        }
    }
}