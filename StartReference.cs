using Microsoft.Research.DynamicDataDisplay;
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
        struct DataChanell
        {
            public const int SIZE_VECTOR = 256;

            public string name; //  Номер и название канала

            public int aData; // Данные полученые с прибора
            public double aTotalCapacity; // Общая ёмкость
            public double[] aData_Capacity; // Объём данных
            public int[] aData_Frequency; // Частота данных
            public int[] aError_Capacity; // Ошибки ёмкости
            public int[] aError_Frequency; // Ошибки Частатоты

            bool IsDataValid; // Проверка чтение

        }

        public void Reference()
        {
            Random rand = new Random();
            DataChanell[] chanell_Reference = new DataChanell[6];

            bool TestTube1 = Settings.TestTube1;
            bool TestTube2 = Settings.TestTube1;
            bool TestTube3 = Settings.TestTube1;
            bool TestTube4 = Settings.TestTube1;
            bool TestTube5 = Settings.TestTube1;
            bool TestTube6 = Settings.TestTube1;

            List<Point> points1 = new List<Point>();
            List<Point> points2 = new List<Point>();
            List<Point> points3 = new List<Point>();
            List<Point> points4 = new List<Point>();
            List<Point> points5 = new List<Point>();
            List<Point> points6 = new List<Point>();


            if (TestTube1 == true)
            {
                chanell_Reference[0].name = "1 канал";
                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 100);
                    chanell_Reference[0].aData = temp;
                    double x = j;
                    double y = chanell_Reference[0].aData;
                    points1.Add(new Point(x, y));
                }
            }


            Settings.points1 = points1;
            Settings.points2 = points2;
            Settings.points3 = points3;
            Settings.points4 = points4;
            Settings.points5 = points5;
            Settings.points6 = points6;
        }
    }
}
