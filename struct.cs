

struct dataChanell 
{
    const int SIZE_VECTOR = 256;

    string name; //  Номер и название канала

    int[] aData; // Данные полученые с прибора
    double aTotalCapacity; // Общая ёмкость
    double[] aData_Capacity; // Объём данных
    int[] aData_Frequency; // Частота данных
    int[] aError_Capacity; // Ошибки ёмкости
    int[] aError_Frequency; // Ошибки Частатоты

    bool IsDataValid; // Проверка чтение

}