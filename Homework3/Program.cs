/*Задача 29: Напишите программу, которая задаёт массив из N элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
using System;
class Program
{
static void PrintArray(int [] array)
{
	int count = array.Length;
	for(int i = 0; i < count; i++)
	{
		Console.WriteLine("[" + array[i] + "]");
	}
	Console.WriteLine();
}

static void Main(string[] args)
{
	int [] array = new int [0];
	Console.Write("Введите последовательность целых чисел массива без пробелов и запятых = ");
	var numbers = Console.ReadLine();
	int N = Convert.ToInt32(numbers);
			
	array = new int [array.Length+1];
	int [] a = array;
	for(int i = 0; i < a.Length; i++)
	{
		array[i] = a [i];
	}
	array [array.Length-1] = N;
	PrintArray(array);
}
}


/*Вариант 2:
using System;
class Program
{
	static void Main(string[] args)
{
	Console.Write("Введите последовательность целых чисел массива через запятую = ");
	var number = Console.ReadLine();
	string [] array = new string [number.Length];

	int index = 0;
	foreach(var item in number)
	{
		if(item != ',')
		{
			array[index] += item.ToString();

		} else {
			index++;
		}
	}
	Console.Write("[");
	for(int i = 0; i <= index-1; i++)
	{
		Console.Write(array[i] + ",");

	}
	Console.Write(array[index] + "]");
}
}


Вариант 3:
using System;
class Program
{
static void WriteArray(int [] array)
{
	for(int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("[" + array[i] + "]");
	}
}
static void Main(string[] args)
{
	int [] array = new int [0];
	while(true)
	{
		Console.Write("Введите последовательность целых чисел массива = ");
		var str = Console.ReadLine();
		if(str != "end")
		{
			int N = Convert.ToInt32(str);
			
			array = new int [array.Length+1];
			int [] a = array;
			for(int i = 0; i < a.Length; i++)
			{
				array[i] = a [i];
			}
			array [array.Length-1] = N;
		}
		else 
		{ 
			break;
		}
		WriteArray(array);
	}
}
}
*/	
		







