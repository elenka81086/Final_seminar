/*Задача: Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма.*/


void CreatingNewArray(string[] Array, string[] NewArrey)
{
    int saze = 0;
    for (int i = 0; i < Array.Length; i++)
    {
    if(Array[i].Length <= 3)
        {
        NewArrey[saze] = Array[i];
        saze++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
string[] Array = new string[6] {"Russia", "-2", "You", "123", "Hello", "Kazan"};
string[] NewArrey = new string[Array.Length];
CreatingNewArray(Array, NewArrey);
Console.WriteLine("Новый массив из строк, длинна которых не больше 3 символов:");
PrintArray(NewArrey);