//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int getUserLenght(string massege)
{
    Console.WriteLine(massege);
    int len = int.Parse(Console.ReadLine()!);
    return len;
}

int[] generateArray(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int GetNumberEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int lenght = getUserLenght("Введите длину массива: ");
int[] array = generateArray(lenght);
int number = GetNumberEven(array);
printArray(array);
Console.WriteLine($"Количество четных чисел в данном массиве равно {number}");
