/* Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int Rnd(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

int RandNum = Rnd(100, 999);

int firstNum = RandNum % 10;
int thirdNum = (RandNum / 100) % 10;
System.Console.WriteLine($"Число {RandNum} без второй цифры {thirdNum * 10 + firstNum}");

