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
        public GraphWindow()
        {
            InitializeComponent();
            Loaded += GraphWindow_Referance;
        }
        
        private void GraphWindow_Referance (object sender, RoutedEventArgs e)
        {

            bool TestTube1 = Settings.TestTube1;
            if(TestTube1 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);

                // Создаем массив точек для отображения на графике
                int pointCount = 100;
                Random rand = new Random();
                List<Point> points = new List<Point>();
                for (int i = 0; i < pointCount; i++)
                {
                    double x = i;
                    double y = rand.Next(0, 10);
                    points.Add(new Point(x, y));
                }
                dataSource.AppendMany(points);

                // Подключаем источник данных к графику
                lineGraphReference_1.DataSource = dataSource;
            }

            bool TestTube2 = Settings.TestTube2;
            if (TestTube2 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);

                // Создаем массив точек для отображения на графике
                int pointCount = 100;
                Random rand = new Random();
                List<Point> points = new List<Point>();
                for (int i = 0; i < pointCount; i++)
                {
                    double x = i;
                    double y = rand.Next(0, 10);
                    points.Add(new Point(x, y));
                }
                dataSource.AppendMany(points);

                // Подключаем источник данных к графику
                lineGraphReference_2.DataSource = dataSource;
            }

            bool TestTube3 = Settings.TestTube3;
            if (TestTube3 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);

                // Создаем массив точек для отображения на графике
                int pointCount = 100;
                Random rand = new Random();
                List<Point> points = new List<Point>();
                for (int i = 0; i < pointCount; i++)
                {
                    double x = i;
                    double y = rand.Next(0, 10);
                    points.Add(new Point(x, y));
                }
                dataSource.AppendMany(points);

                // Подключаем источник данных к графику
                lineGraphReference_3.DataSource = dataSource;
            }

            bool TestTube4 = Settings.TestTube4;
            if (TestTube4 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);

                // Создаем массив точек для отображения на графике
                int pointCount = 100;
                Random rand = new Random();
                List<Point> points = new List<Point>();
                for (int i = 0; i < pointCount; i++)
                {
                    double x = i;
                    double y = rand.Next(0, 10);
                    points.Add(new Point(x, y));
                }
                dataSource.AppendMany(points);

                // Подключаем источник данных к графику
                lineGraphReference_4.DataSource = dataSource;
            }

            bool TestTube5 = Settings.TestTube5;
            if (TestTube5 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);

                // Создаем массив точек для отображения на графике
                int pointCount = 100;
                Random rand = new Random();
                List<Point> points = new List<Point>();
                for (int i = 0; i < pointCount; i++)
                {
                    double x = i;
                    double y = rand.Next(0, 10);
                    points.Add(new Point(x, y));
                }
                dataSource.AppendMany(points);

                // Подключаем источник данных к графику
                lineGraphReference_5.DataSource = dataSource;
            }

            bool TestTube6 = Settings.TestTube6;
            if (TestTube6 == true)
            {
                var dataSource = new ObservableDataSource<Point>();
                dataSource.SetXMapping(p => p.X);
                dataSource.SetYMapping(p => p.Y);

                // Создаем массив точек для отображения на графике
                int pointCount = 100;
                Random rand = new Random();
                List<Point> points = new List<Point>();
                for (int i = 0; i < pointCount; i++)
                {
                    double x = i;
                    double y = rand.Next(0, 10);
                    points.Add(new Point(x, y));
                }
                dataSource.AppendMany(points);

                // Подключаем источник данных к графику
                lineGraphReference_6.DataSource = dataSource;
            }

            plotter.Viewport.FitToView();
        }
    }
}