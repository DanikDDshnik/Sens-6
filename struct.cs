

struct dataChanell 
{
    const int SIZE_VECTOR = 256;

    string name; //  ����� � �������� ������

    int[] aData; // ������ ��������� � �������
    double aTotalCapacity; // ����� �������
    double[] aData_Capacity; // ����� ������
    int[] aData_Frequency; // ������� ������
    int[] aError_Capacity; // ������ �������
    int[] aError_Frequency; // ������ ���������

    bool IsDataValid; // �������� ������

}