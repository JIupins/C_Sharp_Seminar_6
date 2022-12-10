// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

double[] CreateArray(int num)
{
    double[] ary = new double[num];

    for (int i = 0; i < ary.Length; i++)
    {
        Console.Write($"Введите значение {i+1}-го числа: ");
        ary[i] = Convert.ToDouble(Console.ReadLine());
    }

    return ary;
}

void QuantityPositiveNumbers(double[] arr)
{
    int quantity = default;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) quantity++;
    }

    Console.WriteLine($"В ряде введеных чисел [{string.Join("; ", arr)}] всего {quantity} чисел(ла), значения которых больше нуля.");
}

Console.Write("Введите колличество чисел в рассматриваемом ряду: ");
int number = Convert.ToInt32(Console.ReadLine());

double[] array = new double[number];

array = CreateArray(number);

QuantityPositiveNumbers(array);