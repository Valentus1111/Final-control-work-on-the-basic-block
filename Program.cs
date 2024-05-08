/*Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


string[] FillArray() 
{
    System.Console.WriteLine("Введите размер массива: "); 
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size]; //создаем массив строк
    for (int i = 0; i < size; i ++) //заполняем массив строк
    {
        System.Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = System.Console.ReadLine();
    }
    return array; //возвращаем массив строк
}

void PrintArray(string[] array) //Печатает массив строк в консоль
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i ++) //выводим массив строк
        System.Console.Write($"“{array[i]}”, "); //добавляем кавычки, вставляем значение элемента массива array[i], запятую и пробел
    System.Console.Write($"“{array[array.Length-1]}”]"); //последний элемент массива array[array.Length-1] без запятой
    System.Console.WriteLine();
}

string[] ResultArray(string[] array) //Формируем новый массив строк из имеющегося массива, где элементы имеют длину <= 3 символа
{
    int n = 0;
    int k = 0;
    for (int i = 0; i < array.Length; i ++) //цикл для подсчета коротких элементов
    {
        if (array[i].Length <= 3) n ++; //проверяем длину элемента массива array[i]
    }
    string[] arrayRes = new string[n]; //создаем новый массив строк
    for (int i = 0; i < array.Length; i ++) //цикл для копирования коротких строк в новый массив
     {
        if (array[i].Length <= 3)
        {
            arrayRes[k] = array[i];
            k ++;
        }
    }
    return arrayRes; //возвращаем новый массив строк
}

string[] arraySet = FillArray();
System.Console.WriteLine();
System.Console.WriteLine("Первоначальный массив:");
PrintArray(arraySet);
System.Console.WriteLine();               
string[] arrayRes = ResultArray(arraySet);
System.Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(arrayRes);
