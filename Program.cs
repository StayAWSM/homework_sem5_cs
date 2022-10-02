//---------Используемые методы------------
double[] FillArrayTask1() //Метод создания и наполнения массива для задачи 1
{

    Random rnd = new Random();
    double[] array = new double[rnd.Next(3, 9)];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

double[] FillArrayTask2() //Метод создания и наполнения массива для задачи 2
{

    Random rnd = new Random();
    double[] array = new double[rnd.Next(4, 9)];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }

    return array;
}

double[] FillArrayTask3() //Метод создания и наполнения массива для задачи 3
{

    Random rnd = new Random();
    double[] array = new double[rnd.Next(4, 9)];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() + rnd.Next(-100, 100)), 2);
    }

    return array;
}

void PrintArray(double[] array) //Метод печати массива
{
    Console.WriteLine("[" + String.Join("; ", array) + "]");
    // Console.Write("[ "); ---- Альтернатива длинная
    // for (int i = 0; i < array.Length; i++)
    //     if (i < array.Length - 1)
    //         Console.Write(array[i] + "; ");
    //     else
    //         Console.Write(array[i] + " ");
    // Console.Write("]");
}

void NumChet(double[] array) // Метод отображения количества чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}

void SumNechet(double[] array) //Метод отображения суммы элементов, стоящих на нечётных позициях
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна: " + sum);
}

void Raznica(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
        else if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + Math.Round((Max - Min), 2));
}

//------------Задачи---------------
void task1()
{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    Console.Clear();
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    double[] array = FillArrayTask1();
    PrintArray(array);
    Console.WriteLine();
    NumChet(array);
    Console.ReadKey();
}

void task2()
{
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0
    Console.Clear();
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    double[] array = FillArrayTask2();
    PrintArray(array);
    Console.WriteLine();
    SumNechet(array);
    Console.ReadKey();
}

void task3()
{
    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76
    Console.Clear();
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    double[] array = FillArrayTask3();
    PrintArray(array);
    Raznica(array);
    Console.ReadKey();
}



//------------Выполнение программы---------------
void Main()
{
    Console.Clear();
    Console.WriteLine("**************************************** \n Выберите задачу, которую хотите решить:\n\t1 - Задача 34 \n\t2 - Задача 36 \n\t3 - Задача 38 \n\t4 - Выход");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            task1();
            Main();
            break;
        case 2:
            task2();
            Main();
            break;
        case 3:
            task3();
            Main();
            break;
        case 4:
            Console.WriteLine("Пока!");
            Console.ReadKey();
            break;
    }
}
Main();