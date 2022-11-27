// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArr(int num)
{
    double[] arr = new double[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (new Random().Next(0, 100))+ Math.Round(new Random().NextDouble(),2);
    }

    Console.WriteLine("Массив создан. Ваш массив: " + string.Join(" ", arr));
    return arr;
}

void Raznica(double[]arr){
    double max= arr[0];
    double min= arr[0];
    
    foreach(double i in arr){
        if(i>max)max=i;
        if(i<min)min=i;
    }
    double raznica=(max-min);
    Console.WriteLine($"Максимальный элемент {max}, минимальный элемент {min}, разница = {raznica}");
}
Console.Write("Введите длину массива:");
int size= Convert.ToInt32(Console.ReadLine());
double [] array= FillArr(size);
Raznica(array);
