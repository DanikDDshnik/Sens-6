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

            List<Point> points1_ref = new List<Point>();
            List<Point> points2_ref = new List<Point>();
            List<Point> points3_ref = new List<Point>();
            List<Point> points4_ref = new List<Point>();
            List<Point> points5_ref = new List<Point>();
            List<Point> points6_ref = new List<Point>();

            points1_ref = Settings.points1_ref;
            points2_ref = Settings.points2_ref;
            points3_ref = Settings.points3_ref;
            points4_ref = Settings.points4_ref;
            points5_ref = Settings.points5_ref;
            points6_ref = Settings.points6_ref;

            List<Point> points1_tgt = new List<Point>();
            List<Point> points2_tgt = new List<Point>();
            List<Point> points3_tgt = new List<Point>();
            List<Point> points4_tgt = new List<Point>();
            List<Point> points5_tgt = new List<Point>();
            List<Point> points6_tgt = new List<Point>();

            points1_tgt = Settings.points1_tgt;
            points2_tgt = Settings.points2_tgt;
            points3_tgt = Settings.points3_tgt;
            points4_tgt = Settings.points4_tgt;
            points5_tgt = Settings.points5_tgt;
            points6_tgt = Settings.points6_tgt;


            bool TestTube1 = Settings.TestTube1;
            bool TestTube2 = Settings.TestTube2;
            bool TestTube3 = Settings.TestTube3;
            bool TestTube4 = Settings.TestTube4;
            bool TestTube5 = Settings.TestTube5;
            bool TestTube6 = Settings.TestTube6;

            if (TestTube1 == true)
            {
                var dataSource_ref = new ObservableDataSource<Point>();
                var dataSource_tgt = new ObservableDataSource<Point>();

                dataSource_ref.SetXMapping(p => p.X);
                dataSource_ref.SetYMapping(p => p.Y);
                dataSource_tgt.SetXMapping(p => p.X);
                dataSource_tgt.SetYMapping(p => p.Y);

                dataSource_ref.AppendMany(points1_ref);
                lineGraphReference_1.DataSource = dataSource_ref;
                dataSource_tgt.AppendMany(points1_tgt);
                lineGraphTarget_1.DataSource = dataSource_tgt;
            }

            if (TestTube2 == true)
            {
                var dataSource_ref = new ObservableDataSource<Point>();
                var dataSource_tgt = new ObservableDataSource<Point>();

                dataSource_ref.SetXMapping(p => p.X);
                dataSource_ref.SetYMapping(p => p.Y);
                dataSource_tgt.SetXMapping(p => p.X);
                dataSource_tgt.SetYMapping(p => p.Y);

                dataSource_ref.AppendMany(points2_tgt);
                lineGraphReference_2.DataSource = dataSource_ref;
                dataSource_tgt.AppendMany(points2_tgt);
                lineGraphTarget_2.DataSource = dataSource_tgt;
            }

            if (TestTube3 == true)
            {
                var dataSource_ref = new ObservableDataSource<Point>();
                var dataSource_tgt = new ObservableDataSource<Point>();

                dataSource_ref.SetXMapping(p => p.X);
                dataSource_ref.SetYMapping(p => p.Y);
                dataSource_tgt.SetXMapping(p => p.X);
                dataSource_tgt.SetYMapping(p => p.Y);

                dataSource_ref.AppendMany(points3_ref);
                lineGraphReference_3.DataSource = dataSource_ref;
                dataSource_tgt.AppendMany(points3_tgt);
                lineGraphTarget_3.DataSource = dataSource_tgt;
            }

            if (TestTube4 == true)
            {
                var dataSource_ref = new ObservableDataSource<Point>();
                var dataSource_tgt = new ObservableDataSource<Point>();

                dataSource_ref.SetXMapping(p => p.X);
                dataSource_ref.SetYMapping(p => p.Y);
                dataSource_tgt.SetXMapping(p => p.X);
                dataSource_tgt.SetYMapping(p => p.Y);

                dataSource_ref.AppendMany(points4_ref);
                lineGraphReference_4.DataSource = dataSource_ref;
                dataSource_tgt.AppendMany(points4_tgt);
                lineGraphTarget_4.DataSource = dataSource_tgt;
            }


            if (TestTube5 == true)
            {
                var dataSource_ref = new ObservableDataSource<Point>();
                var dataSource_tgt = new ObservableDataSource<Point>();

                dataSource_ref.SetXMapping(p => p.X);
                dataSource_ref.SetYMapping(p => p.Y);
                dataSource_tgt.SetXMapping(p => p.X);
                dataSource_tgt.SetYMapping(p => p.Y);

                dataSource_ref.AppendMany(points5_ref);
                lineGraphReference_5.DataSource = dataSource_ref;
                dataSource_tgt.AppendMany(points5_tgt);
                lineGraphTarget_5.DataSource = dataSource_tgt;
            }

            if (TestTube6 == true)
            {
                var dataSource_ref = new ObservableDataSource<Point>();
                var dataSource_tgt = new ObservableDataSource<Point>();
                
                dataSource_ref.SetXMapping(p => p.X);
                dataSource_ref.SetYMapping(p => p.Y);
                dataSource_tgt.SetXMapping(p => p.X);
                dataSource_tgt.SetYMapping(p => p.Y);

                dataSource_ref.AppendMany(points6_ref);
                lineGraphReference_6.DataSource = dataSource_ref;
                dataSource_tgt.AppendMany(points6_tgt);
                lineGraphTarget_6.DataSource = dataSource_tgt;
            }
            plotter.Viewport.FitToView();
        }
    }
}