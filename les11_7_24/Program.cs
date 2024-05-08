using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace les11_7_24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			Завдання 1:
			//Додаток дозволяє користувачеві переглядати вміст файлу. 
			//Користувач вводить шлях до файлу.Якщо файл існує, його вміст
			//відображається на екрані.Якщо файл не існує, виведіть
			//повідомлення про помилку

			//Console.WriteLine("Enter path to file: ");
			//string path = Console.ReadLine();

			//try
			//{
			//	if (File.Exists(path))
			//	{
			//		using (StreamReader sr = new StreamReader(path))
			//		{
			//			string line = sr.ReadToEnd();
			//			Console.WriteLine(line);
			//		}
			//	}
			//	else
			//	{
			//		Console.WriteLine($"Error! File Not exists");
			//	}
			//}
			//catch (FileNotFoundException e)
			//{
			//	Console.WriteLine($"Error! Not found file {e}");

			//}


			//			Завдання 2:
			//Користувач вводить значення елементів масиву з клавіатури.
			//Додаток надає можливість зберігати вміст масиву у файл.
			//  Завдання 3
			//Додайте до другого завдання можливість завантажувати масив
			//із файлу.


			//Console.WriteLine("Enter elements for array: ");
			//int size = 5;
			//int[] arrays = new int[size];
			//for (int i = 0; i < arrays.Length; i++)
			//{
			//	Console.Write($"Enter {i + 1} number: ");
			//	arrays[i] = int.Parse(Console.ReadLine());
			//}
			//Console.WriteLine("\n");
			//Console.WriteLine("Array:");
			//foreach (int num in arrays)
			//{
			//	Console.Write($"{num} ");
			//}
			//Console.WriteLine("\n");

			//Console.WriteLine("Save the contents of the array to a file: Yes - 1, No - 0");
			//int choice = int.Parse(Console.ReadLine());
			//if (choice == 1)
			//{
			//	using (StreamWriter sw = new StreamWriter("zavdannya2.txt", false))
			//	{
			//		for (int i = 0; i < arrays.Length; i++)
			//		{
			//			sw.WriteLine(arrays[i]);
			//		}
			//	}
			//	Console.WriteLine("\nArray saved to file.\n");

			//	Console.WriteLine("Load array from the file? Yes - 1, No - 0");
			//	int choiceLoad = int.Parse(Console.ReadLine());

			//	if (choiceLoad == 1 && File.Exists("zavdannya2.txt"))
			//	{
			//		using (StreamReader st = new StreamReader("zavdannya2.txt"))
			//		{
			//			Console.WriteLine("\nReading from file:");
			//			string line = st.ReadToEnd();
			//			string[] arrString = line.Split(new char[] { ' ', '\t', '\n' });

			//			int[] loadArray = new int[arrString.Length];

			//			for (int i = 0; i < arrString.Length; i++)
			//			{
			//				if (int.TryParse(arrString[i], out int number))
			//				{
			//					loadArray[i] = number;
			//					Console.Write(loadArray[i] + " ");
			//				}
			//			}
			//		}
			//	}
			//	else
			//	{
			//		Console.WriteLine("Array not loaded from file.");
			//	}

			//}
			//else
			//{
			//	Console.WriteLine("You choice not save arrays");
			//}


			//			Завдання 4:
			//Додаток генерує випадковим чином 10000 цілих чисел. 
			//Збережіть парні числа в один файл, непарні – в інший. За
			//підсумками роботи додатка потрібно відобразити статистику на
			//екрані

			//const int size = 20;
			//int[] arr = new int[size];
			//Random random = new Random();
			//for (int i = 0; i < size; i++)
			//{
			//	arr[i] = random.Next(20);
			//	Console.Write(arr[i] + " ");
			//}
			//Console.WriteLine();

			//int countEven = 0;
			//int countOdd = 0;

			//using (StreamWriter swEven = new StreamWriter("zavdannya4Even.txt", false))
			//using (StreamWriter swOdd = new StreamWriter("zavdannya4Odd.txt", false))

			//	for (int i = 0; i < arr.Length; i++)
			//	{
			//		if (arr[i] % 2 == 0)
			//		{
			//			{
			//				swEven.WriteLine(arr[i]);
			//				countEven++;
			//			}
			//		}
			//		else
			//		{
			//			{
			//				swOdd.WriteLine(arr[i]);
			//				countOdd++;
			//			}
			//		}
			//	}

			//Console.WriteLine($"\nCount even in file: {countEven}, count Odd: {countOdd}");


			//			Завдання 5:
			//Додаток надає користувачеві можливість пошуку по файлу:
			//+  Пошук заданого слова.Додаток показує, чи знайдено слово.Крім того, відображається інформація про те, де знайдено збіг.
			//+  Пошук кількості входження слова у файл. Додаток відображає кількість знайденого слова.
			//+ Пошук заданого слова у зворотному порядку. Наприклад, 
			//+користувач шукає слово «moon». Це означає, що додаток шукає слово «moon» у зворотному напрямку: «noom».
			//За результатами пошуку, додаток відображає кількість входжень.

			//using (StreamWriter sw = new StreamWriter("zavdannya5.txt", false))
			//{
			//	sw.WriteLine("Search for a given word. The application shows whether the word has been found." +
			//		"Also displays information\n about where found coincidence, moon.");
			//}
			//Console.WriteLine("Text:");
			//using (StreamReader st = new StreamReader("zavdannya5.txt"))
			//{
			//	string line = st.ReadToEnd();
			//	Console.WriteLine(line);
			//}


			//Console.WriteLine("\nEnter word for find: ");

			//string word = Console.ReadLine().ToLower();
			//int countSub = 0;

			//using (StreamReader st = new StreamReader("zavdannya5.txt"))
			//{
			//	string line = st.ReadToEnd();
			//	string[] words = line.ToLower().Split(new char[] { ' ', '.', ',' });

			//	foreach (string w in words)
			//	{
			//		if (w == word)
			//		{
			//			countSub++;
			//			Console.WriteLine($"Word '{word}' found in: {line}");
			//		}
			//	}
			//}
			//Console.WriteLine($"Count of substring: {countSub} ");

			//string reversedWord = new string(word.Reverse().ToArray());
			//int countRevereseWord = 0;

			//using (StreamReader stReverse = new StreamReader("zavdannya5.txt"))
			//{
			//	string line = stReverse.ReadToEnd();
			//	string[] words = line.ToLower().Split(new char[] { ' ', '.', ',' }).Reverse().ToArray();

			//	foreach (string w in words)
			//	{
			//		if (w == reversedWord)
			//		{
			//			countRevereseWord++;
			//		}
			//	}
			//}
			//Console.WriteLine($"Count of reverse word {reversedWord}: {countRevereseWord} ");


			//			Завдання 6:
			//Користувач вводить шлях до файлу.Додаток відображає
			//статистичну інформацію про файл:
			//+ кількість речень;
			//+ кількість великих літер;
			//+ кількість маленьких літер;
			//+ кількість голосних літер;
			//+ кількість приголосних літер;
			//+ кількість цифр

			using (StreamWriter sw = new StreamWriter("zav6.txt", false))
			{
				sw.WriteLine("System. Char struct 1method which. Is used to c2heck whether.Unicode character can be");
			}
			using (StreamReader st = new StreamReader("zav6.txt"))
			{
				string line = st.ReadToEnd();
				Console.WriteLine(line);
			}

			Console.WriteLine("\nEnter path to file: \n");
			string path = Console.ReadLine();

			int countSentence = 0;
			int countUpperLetter = 0;
			int cointlowerLetter = 0;
			int countVowels = 0;
			int countConsonants = 0;
			int countDigit = 0;

			if (File.Exists(path))
			{
				using (StreamReader sr = new StreamReader(path))
				{
					string line = sr.ReadToEnd();
					string[] sentence = line.Split(new char[] { '.', '!', '?' });
					foreach (string sentenceP in sentence)
					{
						if (!string.IsNullOrWhiteSpace(sentenceP))   //порожній або містить тільки пробіли та символи переносу рядка
						{
							countSentence++;
							Console.WriteLine(sentenceP.Trim());
						}
					}
					foreach (var item in line)
					{
						if (Char.IsUpper(item))
						{
							countUpperLetter++;
						}
						if (Char.IsLower(item))
						{
							cointlowerLetter++;
						}
					}
					string newsLine = line.ToLower();
					for (int i = 0; i < newsLine.Length; i++)
					{
						if (newsLine[i] == 'a' || newsLine[i] == 'e' || newsLine[i] == 'i'
							|| newsLine[i] == 'o' || newsLine[i] == 'u' || newsLine[i] == 'y')
						{
							countVowels++;
						}
						else if (newsLine[i] == 'b' || newsLine[i] == 'c' || newsLine[i] == 'd' || newsLine[i] == 'f' ||
							 newsLine[i] == 'g' || newsLine[i] == 'h' || newsLine[i] == 'j' || newsLine[i] == 'k' ||
							 newsLine[i] == 'l' || newsLine[i] == 'm' || newsLine[i] == 'n' || newsLine[i] == 'p' ||
							 newsLine[i] == 'q' || newsLine[i] == 'r' || newsLine[i] == 's' || newsLine[i] == 't' ||
							 newsLine[i] == 'v' || newsLine[i] == 'w' || newsLine[i] == 'x' || newsLine[i] == 'y' || newsLine[i] == 'z')
						{
							countConsonants++;
						}
						else if (Char.IsDigit(newsLine[i]))
						{
							countDigit++;
						}
					}
				}
			}
			else
			{
				Console.WriteLine($"Error! File Not exists");
			}
			Console.WriteLine($"Count sentence in file: {countSentence}");
			Console.WriteLine($"Count upper letter: {countUpperLetter}");
			Console.WriteLine($"Count lower letter: {cointlowerLetter}");
			Console.WriteLine($"Count vowel letter: {countVowels}");
			Console.WriteLine($"Count Consonants letter: {countConsonants}");
			Console.WriteLine($"Count digit in file: {countDigit}");
		}
	}
}


