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

        private double ExtractX(Point p)
        {
            return p.X;
        }

        private double ExtractY(Point p)
        {
            return p.Y;
        }

        private void GraphWindow_Referance (object sender, RoutedEventArgs e)
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
                double y = rand.Next(0, 100);
                points.Add(new Point(x, y));
            }
            dataSource.AppendMany(points);

            // Подключаем источник данных к графику
            lineGraph.DataSource = dataSource;

            // Автоматически масштабируем график
            plotter.Viewport.FitToView();
        }
    }
}