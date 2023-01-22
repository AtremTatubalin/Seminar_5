//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int getUserLenght(string massege)
{
    Console.WriteLine(massege);
    int lenght = int.Parse(Console.ReadLine()!);
    return lenght;
}

int [] RandomNumber(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

int AmountOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
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

int Length = getUserLenght("Введите длину массива: ");
int[] Array = RandomNumber(Length);
int Sum = AmountOddPositions(Array);
printArray(Array);
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {Sum}");