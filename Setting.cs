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


        public static List<Point> points1 { get; set; }
        public static List<Point> points2 { get; set; }
        public static List<Point> points3 { get; set; }
        public static List<Point> points4 { get; set; }
        public static List<Point> points5 { get; set; }
        public static List<Point> points6 { get; set; }


        public static string[] chanellName { get; set; } = new string[6];

        public static bool StandartNameChanell_1 { get; set; }
        public static bool StandartNameChanell_2 { get; set; }
        public static bool StandartNameChanell_3 { get; set; }
        public static bool StandartNameChanell_4 { get; set; }
        public static bool StandartNameChanell_5 { get; set; }
        public static bool StandartNameChanell_6 { get; set; }


    }
}
