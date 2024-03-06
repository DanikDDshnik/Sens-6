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
        public static bool TestTube1 { get; set; } //Передаёт значение переключателя канала 1
        public static bool TestTube2 { get; set; } //Передаёт значение переключателя канала 2
        public static bool TestTube3 { get; set; } //Передаёт значение переключателя канала 3
        public static bool TestTube4 { get; set; } //Передаёт значение переключателя канала 4
        public static bool TestTube5 { get; set; } //Передаёт значение переключателя канала 5
        public static bool TestTube6 { get; set; } //Передаёт значение переключателя канала 6


        public static List<Point> points1_ref { get; set; } //Данные после референса канала 1
        public static List<Point> points2_ref { get; set; } //Данные после референса канала 2
        public static List<Point> points3_ref { get; set; } //Данные после референса канала 3
        public static List<Point> points4_ref { get; set; } //Данные после референса канала 4
        public static List<Point> points5_ref { get; set; } //Данные после референса канала 5 
        public static List<Point> points6_ref { get; set; } //Данные после референса канала 6

        public static List<Point> points1_tgt { get; set; } //Данные канала 1 после таргета
        public static List<Point> points2_tgt { get; set; } //Данные канала 1 после таргета
        public static List<Point> points3_tgt { get; set; } //Данные канала 1 после таргета
        public static List<Point> points4_tgt { get; set; } //Данные канала 1 после таргета
        public static List<Point> points5_tgt { get; set; } //Данные канала 1 после таргета
        public static List<Point> points6_tgt { get; set; } //Данные канала 1 после таргета

        public static bool[] CheckReference = new bool[6]; //Массив с данными о том, был референс определённого канала или нет
        public static bool[] CheckTarget = new bool[6]; //Массив с данными о том, был референс определённого канала или нет



    }
}
