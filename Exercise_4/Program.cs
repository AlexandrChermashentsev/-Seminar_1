/* Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int Numbers(string message)
{
    Console.WriteLine(message);
    string numberSTR = Console.ReadLine();
    int number = Convert.ToInt32(numberSTR);
    return number;
}

int numberOne = Numbers("Введите первое число");
int numberTwo = Numbers("Введите второе число");
int numberThree = Numbers("Введите третье число");

int Max(int numberOne, int numberTwo, int numberThree)
{
    int result = numberOne;
    if (numberTwo > result) result = numberTwo;
    if (numberThree > result) result = numberThree;
    return result;
}
int max = Max(numberOne, numberTwo, numberThree);
Console.WriteLine($"Самое большое из трех чисел это {max}");