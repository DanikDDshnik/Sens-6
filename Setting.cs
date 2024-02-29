using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Sens_6;

namespace Sens_6
{
    public static class Settings
    {
        public static bool TestTube1 { get; set; }
        public static bool TestTube2 { get; set; }
        public static bool TestTube3 { get; set; }
        public static bool TestTube4 { get; set; }
        public static bool TestTube5 { get; set; }
        public static bool TestTube6 { get; set; }


        public static List<Point> points1_ref { get; set; }
        public static List<Point> points2_ref { get; set; }
        public static List<Point> points3_ref { get; set; }
        public static List<Point> points4_ref { get; set; }
        public static List<Point> points5_ref { get; set; }
        public static List<Point> points6_ref { get; set; }

        public static List<Point> points1_tgt { get; set; }
        public static List<Point> points2_tgt { get; set; }
        public static List<Point> points3_tgt { get; set; }
        public static List<Point> points4_tgt { get; set; }
        public static List<Point> points5_tgt { get; set; }
        public static List<Point> points6_tgt { get; set; }



    }
}
