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

            List<Point> points1 = new List<Point>();
            List<Point> points2 = new List<Point>();
            List<Point> points3 = new List<Point>();
            List<Point> points4 = new List<Point>();
            List<Point> points5 = new List<Point>();
            List<Point> points6 = new List<Point>();


            if (TestTube1 == true)
            {

                if (Settings.StandartNameChanell_1 == true)
                    chanell_Reference[0].name = "Канал номер 1";
                else
                    chanell_Reference[0].name = Settings.chanellName[0];

                chanell_Reference[0].name = Settings.chanellName[0];
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
                            points1.Add(new Point(i, chanell_Reference[0].aData[i]));
                        }
                    }

                }
            }

            if (TestTube2 == true)
            {
                if (Settings.StandartNameChanell_2 == true)
                    chanell_Reference[1].name = "Канал номер 2";
                else
                    chanell_Reference[1].name = Settings.chanellName[1];

                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[1].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[1].aData[j];
                    points2.Add(new Point(x, y));
                }
            }

            if (TestTube3 == true)
            {
                if (Settings.StandartNameChanell_3 == true)
                    chanell_Reference[2].name = "Канал номер 3";
                else
                    chanell_Reference[2].name = Settings.chanellName[2];

                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[2].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[2].aData[j];
                    points3.Add(new Point(x, y));
                }
            }

            if (TestTube4 == true)
            {
                if (Settings.StandartNameChanell_4 == true)
                    chanell_Reference[3].name = "Канал номер 4";
                else
                    chanell_Reference[3].name = Settings.chanellName[3];

                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[3].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[3].aData[j];
                    points4.Add(new Point(x, y));
                }
            }

            if (TestTube5 == true)
            {
                if (Settings.StandartNameChanell_5 == true)
                    chanell_Reference[4].name = "Канал номер 5";
                else
                    chanell_Reference[4].name = Settings.chanellName[4];

                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[4].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[4].aData[j];
                    points5.Add(new Point(x, y));
                }
            }

            if (TestTube6 == true)
            {

                if (Settings.StandartNameChanell_6 == true)
                    chanell_Reference[5].name = "Канал номер 6";
                else
                    chanell_Reference[5].name = Settings.chanellName[5];

                for (int j = 0; j < 256; j++)
                {
                    int temp = rand.Next(0, 10);
                    chanell_Reference[5].aData[j] = temp;
                    double x = j;
                    double y = chanell_Reference[5].aData[j];
                    points6.Add(new Point(x, y));
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
