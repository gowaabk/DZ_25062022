/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
 */

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int numDay = Prompt("Введите номер дня недели => ");

if (numDay < 8 && numDay > 0) // Проверка правильности ввода
{
    if (numDay >= 1 && numDay <= 5)
    {
        System.Console.WriteLine($"{numDay} -> День не является выходным");
    }
    else System.Console.WriteLine($"{numDay} -> день является выходным");
}
else System.Console.WriteLine($"{numDay} -> не верно. Дней недели всего 7");