using System;
using System.IO;

public class File
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Введите путь до папки, информацию о которой необходимо посмотреть");

		string? path = Console.ReadLine();

		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			int number = 0;
			foreach (string s in files)
			{
				Console.WriteLine($"{number}. {s}");
			}

			Console.WriteLine("Введите номер документа, который планируем изменить и скопировать в родительскую папку?");
			int fileNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Как назвать папку в которую скопируем файл?");
			string nameFolder = Console.ReadLine();

			DirectoryInfo parentInfo = Directory.GetParent(path);

			for (int i = 1; i < (number + 1); i++)
			{
				if (i == fileNumber)
				{
					File.Copy(Path.Combine(path, files[i]), Path.Combine(path, nameFolder, $"копия_{files[i]}"));

				}
			}


		}
	}
}


