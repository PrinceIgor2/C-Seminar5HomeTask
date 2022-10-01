// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int SumOddIndexes(int[] incomingArray)
{
    int sum = 0;
    for (int i = 1; i < incomingArray.Length; i+=2)
    {
        if (i % 2 != 0)
        {
            sum += incomingArray[i];
        }
    }
    return sum;
}


int[] currentArray = getRandomArray(10, 1, 20);
printArray(currentArray);

int count = SumOddIndexes(currentArray);
Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях в массиве {count}");

