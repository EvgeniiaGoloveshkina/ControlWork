// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] ArrayBySymbol(string[] array, int number)
{
    int length = array.Length;
    int j = 0;
    string[] tempArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        int size = array[i].Length;
        if (size <= number)
        {
            tempArray[j] = array[i];
            j++;
        }
    }

    string[] newArray = new string[j];
    for (int i = 0; i < j; i++)
    {
        newArray[i]=tempArray[i];
    }
    return newArray;
}


Console.WriteLine("Задайте эл-ты массива (через пробел)");
string[] strArray = Console.ReadLine().Split(' ').ToArray();
Console.WriteLine("Новый массив: ");
string[] newStrArray= ArrayBySymbol(strArray, 3);
PrintArray(newStrArray);
