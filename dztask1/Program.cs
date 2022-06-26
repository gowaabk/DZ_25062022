/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int number = Prompt("Введите 3-значное число => ");

if (number >= 100 && number <= 999) // Проверка ввода 3-значного числа
{
    int m = (number / 10) % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} => {m}");
}
else System.Console.WriteLine($"Число {number} не 3-значное число");