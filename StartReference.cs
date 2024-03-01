using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;


namespace Sens_6
{
    public partial class StartReference
    {


        public void Reference()
        {
            Random rand = new Random();
            DataChanell[] chanell_Reference = new DataChanell[6];

            for(int i = 0; i < 6; i++)
            {
                chanell_Reference[i].aData = new int[256];
                chanell_Reference[i].aTotalCapacity = new double[256];
                chanell_Reference[i].aData_Capacity = new double[256];
                chanell_Reference[i].aData_Frequency = new int[256];
                chanell_Reference[i].aError_Capacity = new int[256];
                chanell_Reference[i].aError_Frequency = new int[256];
            }

            bool TestTube1 = Settings.TestTube1;
            bool TestTube2 = Settings.TestTube2;
            bool TestTube3 = Settings.TestTube3;
            bool TestTube4 = Settings.TestTube4;
            bool TestTube5 = Settings.TestTube5;
            bool TestTube6 = Settings.TestTube6;

            List<Point> points1_ref = new List<Point>();
            List<Point> points2_ref = new List<Point>();
            List<Point> points3_ref = new List<Point>();
            List<Point> points4_ref = new List<Point>();
            List<Point> points5_ref = new List<Point>();
            List<Point> points6_ref = new List<Point>();

            bool[] CheckReference = new bool[6]; 


            if (TestTube1 == true)
            {
                CheckReference[0] = true;
                for (int j = 0; j < 256; j++)
                {

                    string path = "sens1_ref.txt";
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string list = "0";
                        for (int i = 0; i < 256; i++)
                        {
                            list = sr.ReadLine();
                            chanell_Reference[0].aData[i] = Convert.ToInt32(list);
                            points1_ref.Add(new Point(i, chanell_Reference[0].aData[i]));
                        }
                    }

                }
            }

            if (TestTube2 == true)
            {
                CheckReference[1] = true;
                for (int j = 0; j < 256; j++)
                {

                    string path = "sens2_ref.txt";
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string list = "0";
                        for (int i = 0; i < 256; i++)
                        {
                            list = sr.ReadLine();
                            chanell_Reference[0].aData[i] = Convert.ToInt32(list);
                            points2_ref.Add(new Point(i, chanell_Reference[0].aData[i]));
                        }
                    }

                }
            }

            if (TestTube3 == true)
            {
                CheckReference[2] = true;
                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[2].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[2].aData[j];
                    points3_ref.Add(new Point(x, y));
                }
            }

            if (TestTube4 == true)
            {
                CheckReference[3] = true;
                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[3].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[3].aData[j];
                    points4_ref.Add(new Point(x, y));
                }
            }

            if (TestTube5 == true)
            {
                CheckReference[4] = true;
                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[4].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[4].aData[j];
                    points5_ref.Add(new Point(x, y));
                }
            }

            if (TestTube6 == true)
            {
                CheckReference[5] = true;
                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[5].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[5].aData[j];
                    points6_ref.Add(new Point(x, y));
                }
            }


            Settings.points1_ref = points1_ref;
            Settings.points2_ref = points2_ref;
            Settings.points3_ref = points3_ref;
            Settings.points4_ref = points4_ref;
            Settings.points5_ref = points5_ref;
            Settings.points6_ref = points6_ref;

            Settings.CheckReference = CheckReference;
        }
    }
}
