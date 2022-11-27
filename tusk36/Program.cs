// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArr(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }

    Console.WriteLine("Массив создан. Ваш массив: " + string.Join(" ", arr));
    return arr;
}

int Summa (int[]arr){
int sum=0;
for (int i = 1; i<arr.Length; i+=2){
    sum+=arr[i];
}
return sum;
}

Console.Write("Введите длину будущего массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = FillArr(num);

Console.WriteLine("Сумма чисел на нечетныйх индексах = "+ Summa(array));