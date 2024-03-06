using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;

namespace Sens_6
{
    public partial class StartTarget
    {
        public void Target()
        {
            Random rand = new Random();  
            DataChanell[] chanell_Target = new DataChanell[6];

            for (int i = 0; i < 6; i++)
            {
                chanell_Target[i].aData = new int[256];
                chanell_Target[i].aTotalCapacity = new double[256];
                chanell_Target[i].aData_Capacity = new double[256];
                chanell_Target[i].aData_Frequency = new int[256];
                chanell_Target[i].aError_Capacity = new int[256];
                chanell_Target[i].aError_Frequency = new int[256];
            }

            List<Point> points1_tgt = new List<Point>();
            List<Point> points2_tgt = new List<Point>();
            List<Point> points3_tgt = new List<Point>();
            List<Point> points4_tgt = new List<Point>();
            List<Point> points5_tgt = new List<Point>();
            List<Point> points6_tgt = new List<Point>();

            bool TestTube1 = Settings.TestTube1;
            bool TestTube2 = Settings.TestTube2;
            bool TestTube3 = Settings.TestTube3;
            bool TestTube4 = Settings.TestTube4;
            bool TestTube5 = Settings.TestTube5;
            bool TestTube6 = Settings.TestTube6;

            bool[] CheckTarget = new bool[6];

            if(TestTube1 == true)
            {
                CheckTarget[0] = true;
                for (int i = 0; i < 256; i++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Target[0].aData[i] = temp;
                    double x = i;
                    double y = chanell_Target[0].aData[i];
                    points1_tgt.Add(new Point(x, y));
                }
            }

            if (TestTube2 == true)
            {
                CheckTarget[1] = true;
                for (int i = 0; i < 256; i++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Target[1].aData[i] = temp;
                    double x = i;
                    double y = chanell_Target[1].aData[i];
                    points2_tgt.Add(new Point(x, y));

                }
            }

            if (TestTube3 == true)
            {
                CheckTarget[2] = true;
                string path = "sens1_tgt.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    string list = "0";
                    for (int i = 0; i < 256; i++)
                    {
                        list = sr.ReadLine();
                        chanell_Target[0].aData[i] = Convert.ToInt32(list);
                        points3_tgt.Add(new Point(i, chanell_Target[0].aData[i]));
                    }
                }
            }

            if (TestTube4 == true)
            {
                CheckTarget[3] = true;
                string path = "sens2_tgt.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    string list = "0";
                    for (int i = 0; i < 256; i++)
                    {
                        list = sr.ReadLine();
                        chanell_Target[0].aData[i] = Convert.ToInt32(list);
                        points4_tgt.Add(new Point(i, chanell_Target[0].aData[i]));
                    }
                }
            }

            if (TestTube5 == true)
            {
                CheckTarget[4] = true;
                for (int i = 0; i < 256; i++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Target[4].aData[i] = temp;
                    double x = i;
                    double y = chanell_Target[4].aData[i];
                    points5_tgt.Add(new Point(x, y));
                }

            }

            if (TestTube6 == true)
            {
                CheckTarget[5] = true;
                for (int i = 0; i < 256; i++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Target[5].aData[i] = temp;
                    double x = i;
                    double y = chanell_Target[5].aData[i];
                    points6_tgt.Add(new Point(x, y));

                }

            }

            Settings.points1_tgt = points1_tgt;
            Settings.points2_tgt = points2_tgt;
            Settings.points3_tgt = points3_tgt;
            Settings.points4_tgt = points4_tgt;
            Settings.points5_tgt = points5_tgt;
            Settings.points6_tgt = points6_tgt;

            Settings.CheckTarget = CheckTarget;
        }
    }
}