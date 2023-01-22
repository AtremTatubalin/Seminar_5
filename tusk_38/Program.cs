//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int getUserLenght(string massege)
{
    Console.Write("Введите длину массива: ");
    int lenght = int.Parse(Console.ReadLine()!);
    return lenght;
}

int[] RandomNumber(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

int Difference(int[] array)
{
    int max = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    int min = max;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    result = max - min;
    return result;
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

int Lenght = getUserLenght("Введите длину массива: ");
int[] Array = RandomNumber(Lenght);
int Dif = Difference(Array);
printArray(Array);
Console.WriteLine($"Разница между наибольшим и наименьшим членом массива равна: {Dif}");