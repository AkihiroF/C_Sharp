
using System;
using System.Collections.Generic;
class GFG
{

	// смотрим есть ли нужные символы
	static bool isVowel(char ch)
	{
		ch = char.ToUpper(ch);
		return (ch == 'A' || ch == 'E'
				|| ch == 'I' || ch == 'O'
				|| ch == 'U' || ch == 'Y' || ch =='a' || ch =='e' || ch == 'y' || ch =='u' || ch == 'i' || ch == 'o');
	}

	// возвращаем колличество глассных
	static int countVowels(string str)
	{
		int count = 0;
		for (int i = 0; i < str.Length; i++)
			if (isVowel(str[i])) // проверка
				++count;
		return count;
	}

	//Функция для сортировки массива в соответствии с количеством гласных
	static void sortArr(string[] arr, int n)
	{

		// хранение кол-ва глассных
		List<Tuple<int, string>> vp = new List<Tuple<int, string>>();

		// вставка колличества букв
		for (int i = 0; i < n; i++)
		{
			vp.Add(new Tuple<int, string>(countVowels(arr[i]), arr[i]));
		}

		// сортировка по кол-ву гласных
		vp.Sort();

		// Вывод отсортированного 
		for (int i = 0; i < vp.Count; i++)
			Console.Write(vp[i].Item2 + " ");
	}

	// основа
	static void Main()
	{
		string[] Ass;
		Console.Write("Enter text ");
		string text = Console.ReadLine();
		Ass = text.Split(' ');
		int n = Ass.Length;
		sortArr(Ass, n);
	}
}
