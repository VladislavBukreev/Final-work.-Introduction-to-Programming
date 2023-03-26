//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("Ведите любые слова через пробел :");
string stroka = Console.ReadLine()!;
string[] array = stroka.Split(" ");
int size = SortingMethod(array);
Console.WriteLine($" [    {String.Join(", ", NewArray(size))}    ]");


int SortingMethod(string[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            res = res + 1;
        }
    }
    return res;
}


string[] NewArray(int size)
{
    string[] ArrayRes = new string[size];
    int i = 0;
    int j = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            ArrayRes[j] = array[i];
            j = j + 1;
        }
        i = i + 1;
    }
    return ArrayRes;

}

Console.ReadLine();