/*Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter the number");
string numberSTR = Console.ReadLine();
int number = int.Parse(numberSTR);
int index = 0;

if (number == 0) Console.WriteLine("Вы ввели 0, введите другое число");
if (number > 0)
{
    index = 1;
    while (index <= number)
    {
        if (index % 2 == 0) Console.Write($"{index}, ");
        index++;
    }
}
else 
{
    if (number < 0)
    {
        index = -1;
        while (index >= number)
        {
            if (index % 2 == 0) Console.Write($"{index}, ");
            index--;
        }
    }
}