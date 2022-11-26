// Написать программу которая из имеющегося массива из строк сформирует массив из строк, длина котрых менше 
// либо равна 3 символа. Первоначальный массив  можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма.

string[] TestMas = new string[] {"hhhgj", "ghgghgjhghjg", "hj", "780", "jhkjhkjkj", "u"};

Console.WriteLine($"[{String.Join(",", TestMas)}]");
Console.WriteLine($"[{String.Join(",", ThreeMas(TestMas, 3))}]");

//******************************* Method filtering elements of array by length string ******************************************************
string[] ThreeMas(string[] InpMas, int N)
{
    int n = 0;
    for(int i = 0; i < InpMas.Length; i++)
    {
        if (InpMas[i].Length <= N)
        {
            n++;
        }
    }
    string[] OutMas = new string[n];
    int j = 0;
        for(int i = 0; i < InpMas.Length; i++)
    {
        if (InpMas[i].Length <= N)
        {
            OutMas[j] = InpMas[i];
            j++;
        }
    }
    return OutMas;
}
