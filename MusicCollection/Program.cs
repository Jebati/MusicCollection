using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MusicCollection
{
    class Program
    {
        private static List<Group> groups = new List<Group>(); 
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("[Меню]");
                Console.WriteLine("1 - Ввод коллекции вручную");
                Console.WriteLine("2 - Просмотр коллекции");
                Console.WriteLine("3 - Импорт коллекции");
                Console.WriteLine("4 - Экспорт коллекции");
                Console.WriteLine("* - Завершить работу");
                Console.Write("Ввод: ");

                string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            groups = Reader.GetGroups();
                            break;
                        case "2":
                            if (groups.Count != 0) Writter.PrintGroups(groups);
                            else Console.WriteLine("Колекция пустая.\n");
                            break;
                        case "3":
                            bool result = await Storage.SetGroups(groups);
                            if(result)
                            {
                                Console.WriteLine("Коллекция экспортирована в файл collection.json.\n");
                            } else
                            {
                                Console.WriteLine("Ошибка экспортирования.\n");
                            }
                            break;
                        case "4":
                            Console.Write("Введите путь до файла: ");
                            string path = Console.ReadLine();
                            groups = Storage.GetGroups(path);
                            break;
                        default:
                            Process.GetCurrentProcess().Kill();
                            break;
                    }

            }

        }
    }
}
