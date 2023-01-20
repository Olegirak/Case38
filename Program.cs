/*Задайте массив вещественных чисел. Найдите разницу между максимальным
 и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] generateArray(int length, int start, int end)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArray(double[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i] + " ";
    }
    result = result[..^1] + "]";
    Console.WriteLine(result);
}
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

double FindDifMaxMin(double[] array)
{
    double Min = array[0];
    double Max = Min;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min)
        {
            Min = array[i];
        }
        if (array[i] > Max)
        {
            Max = array[i];
        }
    }
    double result = Max - Min;
    return result;
}

int length = getUserDate("Введите число элементов массива");
int start = getUserDate("Введите начало диапазона");
int end = getUserDate("Введите конец диапазона");
double[] array = generateArray(length, start, end);
printArray(array);
double dif = FindDifMaxMin(array);
Console.WriteLine(dif);
