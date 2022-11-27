// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    Console.WriteLine("Ваш массив: " + string.Join(",", arr));
    return arr;

}


int KolichestvoChetnih(int[] array)
{
    int check = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0) check++;
    }

    return check;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArr(num);

Console.Write("Количество четных чисел в массиве: " +  KolichestvoChetnih(arr));
