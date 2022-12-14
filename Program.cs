using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Введите путь до папки, информацию"+
		" о которой необходимо посмотреть");
   
        string path = Console.ReadLine();
	    
	var DirectoryInfo? directory = new DirectoryInfo(path);
        
	if (directory.Exists is false)
         {
		Console.WriteLine($"Папки по пути {path} не существует");
		return;
	 }
		
            var FileInfo[]? files = directory.GetFiles();
            int number = 0;
            foreach (var FileInfo file in files)
            {
                Console.WriteLine($"{++number}. {file.Name}");
            }
			
		Console.WriteLine("Введите номер документа, который планируем"+
		" изменить и скопировать в родительскую папку?");
		int fileNumber = Convert.ToInt32(Console.ReadLine());
			
		Console.WriteLine("Как назвать папку в которую скопируем файл?");
		string nameFolder = Console.ReadLine();
			
		DirectoryInfo parentInfo = directory.Parent;
		
		parentInfo.CreateSubdirectory(nameFolder);
		File.Copy(files[fileNumber-1].FullName,
			  Path.Combine((targetDirectory.FullName,$"копия_{files[i]}")
			
		int i = fileNumber; // присвоили значение без проверки

		string pathParent = Path.Combine(path, nameFolder, $"копия_{files[fileNumber-1]}");
		File.Copy(Path.Combine(path, files[i].FullName),pathParent); 
		
		// попытка вставить # и @
								   
		string line;
		StreamReader fileReader = new StreamReader(pathParent);
		while ((line = fileReader.ReadLine()) != null)
		{
			int Num;
			double NumDouble;
			bool isNum = (int.TryParse(line, out Num) || Double.TryParse(line, out NumDouble));
			if (isNum)
			{
				line = "#" + line;
			}
			else
			{
				line = "@" + line;
			}
		}
			fileReader.Close();
      		
    }
}
