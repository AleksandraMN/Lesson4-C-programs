/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


using System;
class Program
{
static void Main(string[] args)
	{
		Console.Write("Введите целое натуральное число n = ");
		int n = Convert.ToInt32(Console.ReadLine());
	
		int sum = 0;
		do
		{
			sum += n % 10;
			n = n/10;
		}
		while (n != 0);
		Console.Write("sum = {0}", sum + ".");
		}
}






