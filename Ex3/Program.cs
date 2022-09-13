int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}