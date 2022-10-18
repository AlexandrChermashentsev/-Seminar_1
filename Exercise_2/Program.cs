/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int Numbers(string messege)
{
    Console.WriteLine(messege);
    string numberSTR = Console.ReadLine();
    int number = int.Parse(numberSTR);
    return number;
}

int numberOne = Numbers("Введите первое число");
int numberTwo = Numbers("Введите второе число");
if (numberOne > numberTwo)
{
    Console.WriteLine($"Число {numberOne} больше числа {numberTwo}");
}
else
{
    if (numberOne < numberTwo)
    {
        Console.WriteLine($"Число {numberTwo} больше числа {numberOne}");
    }
    else
    {
        Console.WriteLine($"Числа равны");
    }
}
