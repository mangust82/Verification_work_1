// Написать программу которая из имеющегося массива из строк сформирует массив из строк, длина котрых менше 
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] TestMas = new string[] {"hhhgj", "ghgghgjhghjg", "hj", "780", "jhkjhkjkj", "u"};

Console.WriteLine($"[{String.Join(",", TestMas)}]");
ThreeMas(TestMas);
Console.WriteLine($"[{String.Join(",", ThreeMas(TestMas))}]");

//******************************* Method creating new array ******************************************************
string[] ThreeMas(string[] InpMas)
{
    int n = 0;
    for(int i = 0; i < InpMas.Length; i++)
    {
        if (InpMas[i].Length <= 3)
        {
            n++;
        }
    }

}