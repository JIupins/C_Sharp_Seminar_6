// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double[] CreateArrayNumbers(string letter)
{
    double[] array = new double[2];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение {letter + (i + 1)}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

    return array;
}

void FindCoordinatsPointCross(double[] firstCol, double[] secondCol)
{
    double x = (firstCol[1] - firstCol[0]) / (secondCol[0] - secondCol[1]);
    double y = secondCol[0] * x + firstCol[0];

    Console.WriteLine($"Точка пересечения прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, при условии что: " +
                      $"b1 = {firstCol[0]}, b2 = {firstCol[1]}, k1 = {secondCol[0]}, k2= {secondCol[1]}, равна: x = {x}; y = {y}.");
}

double[] firstCollection = new double[2];
double[] secondCollection = new double[2];

FindCoordinatsPointCross(firstCollection = CreateArrayNumbers("b"), secondCollection = CreateArrayNumbers("k"));