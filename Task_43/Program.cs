// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double[] CreateArrayNumbers(string letter)
{
    double[] ary = new double[2];

    for (int i = 0; i < ary.Length; i++)
    {
        Console.Write($"Введите значение {letter + (i + 1)}: ");
        ary[i] = Convert.ToDouble(Console.ReadLine());
    }

    return ary;
}

void FindCoordinatsPointCross(double[] firstArr, double[] secondArr)
{
    double x = (firstArr[1] - firstArr[0]) / (secondArr[0] - secondArr[1]);
    double y = secondArr[0] * x + firstArr[0];

    Console.WriteLine($"Точка пересечения прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, при условии что: " +
                      $"b1 = {firstArr[0]}, b2 = {firstArr[1]}, k1 = {secondArr[0]}, k2= {secondArr[1]}, равна: x = {x}; y = {y}.");
}

double[] firstCollection = new double[2];
double[] secondCollection = new double[2];

FindCoordinatsPointCross(firstCollection = CreateArrayNumbers("b"), secondCollection = CreateArrayNumbers("k"));