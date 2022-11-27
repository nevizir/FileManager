using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace FileManager
{
    class Programe
    {

        public void AddDirection(string dirPath)
        {
            
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            if (dir.Exists)
                Console.WriteLine("Directory is already exist!");
            else
                dir.Create();

        }

        public void ShowDirection(string dirPath)
        {

            DirectoryInfo dir = new DirectoryInfo(dirPath);

            if (dir.Exists)
            {
                Console.WriteLine("Directory information:\n" +
                    $"Name: {dir.Name}\n" +
                $"Creation Time: {dir.CreationTime}\n");
                
                Console.WriteLine();
            }


            else
                Console.WriteLine("Such direction doesn't Exists");
        }

        public void DeleteDirection(string dirPath)
        {
            
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            dir.Delete();
        }

        public void ShowFiles(string dirPath)
        {
          
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            FileInfo[] files = dir.GetFiles();

            Console.WriteLine("Files:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"\tfile [{i}] - {files[i].Name}");
            }
            Console.ResetColor();
        }

        public void AddFile(string fileName, string dirPath)
        {

            FileInfo file = new FileInfo(fileName);
            if (file.Exists)
            {
                Console.WriteLine("File is already exist");   
            }
            else
            {
                file.Create();
            }
        }

        public void DeleteFile(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            if (file.Exists)
            {
                file.Delete();
            }
            else
                Console.WriteLine("Such file doesn't exists");
        }

        public void PrintFile(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            Console.WriteLine("Directory information:\n" +
                   $"Name: {file.Name}\n" +
               $"Creation Time: {file.CreationTime}\n");

        }

    }

    class Menu
    {
        public Programe programe = new Programe();
        public int index;
        public void Menus()
        {
            do
            {
                Console.WriteLine("\nList:\n[1]Add Direction \n[2]Show Direction\n[3]Delete Direction\n[4]Show Files\n[5]Add File\n[6]Delete File\n[7]Print File\n[0]Exide");
                Console.Write("Enter operation index : ");
                index = int.Parse(Console.ReadLine());
                switch (index)
                {
                    case 0:
                        Console.WriteLine("Okey");
                        break;
                    case 1:
                        programe.AddDirection("test");
                        break;
                    case 2:
                        programe.ShowDirection("test");
                        break;
                    case 3:
                        programe.DeleteDirection("test");
                        break;
                    case 4:
                        programe.ShowFiles("test");
                        break;
                    case 5:
                        programe.AddFile("test.txt", "test");
                        break;
                    case 6:
                        programe.DeleteFile("test.txt");
                        break;
                    case 7:
                        programe.PrintFile("test.txt");
                        break;
                }
            } while (index != 0);
            

        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
           
            Menu menu = new Menu();

            menu.Menus();
        }
    }
}
