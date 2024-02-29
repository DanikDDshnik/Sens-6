//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Sens_6
{
    internal struct DataChanell
    {
        public int Size()
        {
            const int SIZE_VECTOR = 256;
            return SIZE_VECTOR;
        }


        public string name; //  Номер и название канала

        public int[] aData; // Данные полученые с прибора
        public double[] aTotalCapacity; // Общая ёмкость
        public double[] aData_Capacity; // Объём данных
        public int[] aData_Frequency; // Частота данных
        public int[] aError_Capacity; // Ошибки ёмкости
        public int[] aError_Frequency; // Ошибки Частатоты

        bool IsDataValid; // Проверка чтение

    }
}
