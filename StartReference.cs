using Microsoft.Research.DynamicDataDisplay.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sens_6
{
    public partial class StartReference
    {
        private void GraphWindow(object sender, RoutedEventArgs e)
        {
            var dataSource = new ObservableDataSource<Point>();
            dataSource.SetXYMapping(p => p.X, p => p.Y);

            int pointCount = 100;
            Random rand = new Random();
            List<Point> points = new List<Point>();

            for(int i = 0; i < pointCount; i++)
            {
                double x = i;
                double y = rand.Next(0, 100);
                points.Add(new Point(x, y));
            }
            dataSource.AppendMany(points);
        }
    }

}
