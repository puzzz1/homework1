/* Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
 a = 5; b = 25 -> да 
 a = 2 b = 10 -> нет 
 a = 9; b = -3 -> нет 
 a = -3 b = 9 -> да */

int userNumberA = new int();
Console.WriteLine("Введи первое число");
userNumberA = Convert.ToInt32(Console.ReadLine());
int userNumberB = new int();
Console.WriteLine("Введи второе число");
userNumberB = Convert.ToInt32(Console.ReadLine());

int result = userNumberA * userNumberA;

if 
    (result == userNumberB)
    Console.WriteLine("Да!");
else
{ Console.WriteLine("Нет!");}

