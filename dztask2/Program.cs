/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int number = Prompt("Введите число => ");

if (number > 100) // Проверка кол-ва цифр 
{
    int m = (number / 100) % 10;
    System.Console.WriteLine($"Третья цифра числа {number} => {m}");
}
else System.Console.WriteLine($" {number} ->  3-ей цифры нет");