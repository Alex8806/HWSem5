// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
void ChislaVMassive(int M, int B, int[] array)
{
    int check = 0;
    for (int i = 0; i < array.Length; i++)
    {



        if (array[i] > M && array[i] < B)
        {
            check++;
        }
    }

    if (check > 0)
    { Console.Write($"Массив содержит числа от {M} до {B}  - {check} раз (а)"); }
    else { Console.Write($"Массив НЕ содержит содержит числа от {M} до {B}"); }
}



int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1000);
    }
    return arr;
}


Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив:" + string.Join(" ", array));

Console.WriteLine("Введите минимальное число (в задании 10): ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально число (в задании 99): ");
int B = Convert.ToInt32(Console.ReadLine());

ChislaVMassive(M, B, array);
