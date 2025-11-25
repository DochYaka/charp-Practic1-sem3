using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace project
{
    class FileItem
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime Modified { get; set; }
    }

    class ConsoleWindow
    {
        static void Main()
        {
            //  Основной цвет консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            // Размер окна
            int width = 82;
            int height = 25;
            Console.SetWindowSize(width, height);

            List<FileItem> files = new List<FileItem>()
            {
                new FileItem { Name = "Report.docx", Size = 2345, Modified = new DateTime(2025, 09, 22, 14, 30, 0) },
                new FileItem { Name = "Presentation.pptx", Size = 5678, Modified = new DateTime(2025, 09, 20, 10, 15, 0) },
                new FileItem { Name = "Data.xlsx", Size = 1024, Modified = new DateTime(2025, 09, 19, 9, 0, 0) },
                new FileItem { Name = "Image1.png", Size = 345, Modified = new DateTime(2025, 09, 18, 16, 45, 0) },
                new FileItem { Name = "Image2.jpg", Size = 789, Modified = new DateTime(2025, 09, 21, 11, 20, 0) },
                new FileItem { Name = "Video.mp4", Size = 12345, Modified = new DateTime(2025, 09, 17, 8, 10, 0) },
                new FileItem { Name = "Script.cs", Size = 234, Modified = new DateTime(2025, 09, 16, 13, 55, 0) },
                new FileItem { Name = "Archive.zip", Size = 4567, Modified = new DateTime(2025, 09, 15, 19, 30, 0) },
                new FileItem { Name = "Notes.txt", Size = 123, Modified = new DateTime(2025, 09, 14, 7, 5, 0) },
                new FileItem { Name = "Diagram.vsdx", Size = 678, Modified = new DateTime(2025, 09, 13, 15, 40, 0) },
                new FileItem { Name = "Project.csproj", Size = 890, Modified = new DateTime(2025, 09, 12, 12, 0, 0) },
                new FileItem { Name = "Music.mp3", Size = 3456, Modified = new DateTime(2025, 09, 11, 20, 15, 0) },
                new FileItem { Name = "Backup.bak", Size = 5678, Modified = new DateTime(2025, 09, 10, 9, 50, 0) },
                new FileItem { Name = "Config.json", Size = 234, Modified = new DateTime(2025, 09, 9, 14, 25, 0) },
                new FileItem { Name = "Readme.md", Size = 123, Modified = new DateTime(2025, 09, 8, 18, 10, 0) },
                new FileItem { Name = "Test1.cs", Size = 345, Modified = new DateTime(2025, 09, 7, 10, 0, 0) },
                new FileItem { Name = "Test2.cs", Size = 678, Modified = new DateTime(2025, 09, 6, 11, 15, 0) },
                new FileItem { Name = "Log1.log", Size = 123, Modified = new DateTime(2025, 09, 5, 16, 45, 0) },
                new FileItem { Name = "Log2.log", Size = 456, Modified = new DateTime(2025, 09, 4, 9, 30, 0) },
                new FileItem { Name = "Draft.docx", Size = 789, Modified = new DateTime(2025, 09, 3, 14, 5, 0) },
                new FileItem { Name = "Example.pptx", Size = 2345, Modified = new DateTime(2025, 09, 2, 8, 40, 0) },
                new FileItem { Name = "Template.xlsx", Size = 1024, Modified = new DateTime(2025, 09, 1, 19, 20, 0) },
                new FileItem { Name = "Photo1.png", Size = 345, Modified = new DateTime(2025, 08, 31, 13, 15, 0) },
                new FileItem { Name = "Photo2.jpg", Size = 678, Modified = new DateTime(2025, 08, 30, 7, 50, 0) },
                new FileItem { Name = "Video2.mp4", Size = 12345, Modified = new DateTime(2025, 08, 29, 22, 10, 0) },
                new FileItem { Name = "Script2.cs", Size = 234, Modified = new DateTime(2025, 08, 28, 11, 35, 0) },
                new FileItem { Name = "Archive2.zip", Size = 4567, Modified = new DateTime(2025, 08, 27, 17, 5, 0) },
                new FileItem { Name = "Notes2.txt", Size = 123, Modified = new DateTime(2025, 08, 26, 9, 20, 0) },
                new FileItem { Name = "Diagram2.vsdx", Size = 678, Modified = new DateTime(2025, 08, 25, 15, 50, 0) },
                new FileItem { Name = "Project2.csproj", Size = 890, Modified = new DateTime(2025, 08, 24, 12, 30, 0) }

            };

            int startX = 1;
            int startY = 3;

            // Реализация заголовока
            Header header = new Header();

            // Реализация файлов
            Left left = new Left(files, startX, startY);
            Right right = new Right(files, startX, startY);

            // Реализация футера
            Footer footer = new Footer();


            Console.ReadKey();
        }
    }

    // Заголовок
    class Header
    {
        
        public Header()
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            string[] words = { "Левая", "Файл", "Диск", "Команды", "Правая" };
            foreach (string word in words)
            {
                Console.Write(" ".PadLeft(5, ' '));

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(word[i]);
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    if (word[i] == word[0]) continue; Console.Write(word[i]);

                }
            }
            Console.Write(" ".PadLeft(26, ' '));
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 8 30");
        }
    }

    class Left
    {
        public Left(List<FileItem> files, int startX, int startY)
        {
            int maxLines = 30;
            int columns = 3;
            int nameWidth = 12;

            // Вывод заголовка дисков
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            string longPart = new string('\u2550', 12);
            string shortPart = new string('\u2550', 2);
            Console.WriteLine("\u2554" + longPart + "\u2564" + shortPart + " C:\\NC " + "\u2550" + shortPart + "\u2564" + longPart + "\u2557");

            string firstPart = new string(' ', 4);
            string secondPart = new string(' ', 5);

            Console.Write("\u2551");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("C:| Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(secondPart + "\u2502" + firstPart);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(secondPart + "\u2502" + firstPart);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(secondPart + "\u2551");
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Вывод файлов
            for (int i = 0; i < Math.Min(files.Count, maxLines); i++)
            {
                string name = files[i].Name.Length > nameWidth ? files[i].Name.Substring(0, nameWidth - 2) + "~" : files[i].Name;
                int row = i / columns;
                int col = i % columns;

                Console.SetCursorPosition(0, startY + row);
                Console.Write("\u2551");

                int x = startX + col * (nameWidth + 1);
                Console.SetCursorPosition(x, startY + row);
                Console.Write(name.PadRight(nameWidth));
                Console.Write("\u2502");

                Console.SetCursorPosition(39, startY + row);
                Console.Write("\u2551");
            }
            Console.SetCursorPosition(0, 13);
            string longPartD = new string('\u2500', 12);
            string longD = new string('\u2550', 38);
            Console.Write("\u255F" + longPartD + "\u2534" + longPartD + "\u2534" + longPartD + "\u2562");
            Console.SetCursorPosition(0, 14);
            Console.Write("\u2551" + ".." + "           " + "\u2580" + "КАТАЛОГ" + "\u2580" + " 11.10.02  19:40" + "\u2551");
            Console.SetCursorPosition(0, 15);
            Console.Write("\u255A" + longD + "\u255D");
        }
    }

    class Right
    {
        public Right(List<FileItem> files, int startX, int startY)
        {
            int leftMaxLines = 30;
            int maxLines = leftMaxLines / 3;
            int nameWidth = 12;
            int sizeWidth = 10;
            int dateWidth = 10;
            int timeWidth = 6;
            int y = startY;
            int x = 40;

            // Заголовок правой таблицы
            Console.SetCursorPosition(x, 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            string longPart = new string('\u2550', 12);
            string dataPart = new string('\u2550', 10);
            string shortPart = new string('\u2550', 2);
            string timePart = new string('\u2550', 6);

            Console.Write("\u2554" + longPart + "\u2564" + shortPart);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:\\NC ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\u2564" + dataPart + "\u2564" + timePart + "\u2557");

            Console.SetCursorPosition(x, 2);
            string bPart = new string(' ', 5);

            Console.Write("\u2551");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("C:| Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(bPart + "\u2502");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  Размер ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\u2502");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("   Дата  ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(" \u2502");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Время ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\u2551");

            // Вывод файлов
            for (int i = 0; i < Math.Min(files.Count, maxLines); i++)
            {
                string name = files[i].Name.Length > nameWidth ? files[i].Name.Substring(0, nameWidth - 2) + "~" : files[i].Name; ;
                var file = files[i];

                Console.SetCursorPosition(x, y);
                Console.Write("\u2551");
                Console.Write(name.PadRight(nameWidth));
                Console.Write("\u2502");

                Console.SetCursorPosition(x + nameWidth + 2, y);
                Console.Write(file.Size.ToString().PadLeft(sizeWidth - 1));
                Console.Write("\u2502");

                Console.SetCursorPosition(x + nameWidth + sizeWidth + 2, y);
                Console.Write(file.Modified.ToString("dd.MM.yyyy").PadRight(dateWidth));
                Console.Write("\u2502");

                Console.SetCursorPosition(x + nameWidth + sizeWidth + dateWidth + 3, y);
                Console.Write(file.Modified.ToString("HH:mm").PadLeft(timeWidth));
                Console.Write("\u2551");

                y++;
            }
            Console.SetCursorPosition(40, 13);
            string longPartD = new string('\u2500', 12);
            string dataPartD = new string('\u2500', 9);
            string shortPartD = new string('\u2500', 10);
            string timePartD = new string('\u2500', 6);
            string longD = new string('\u2550', 40);

            Console.Write("\u255F" + longPartD + "\u2534" + dataPartD + "\u2534" + shortPartD + "\u2534" + timePartD + "\u2562");
            Console.SetCursorPosition(40, 14);
            Console.Write("\u2551" + ".." + "           " + "\u2580" + "КАТАЛОГ" + "\u2580" + "  11.10.02   19:40" + "\u2551");
            Console.SetCursorPosition(40, 15);
            Console.Write("\u255A" + longD + "\u255D");
        }
    }

    class Footer
    {
        public Footer()
        {
            Console.ResetColor();
            Console.SetCursorPosition(0, 16);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("C:\\NC>");

            string[] words = { "1Помощь ", "2Вызов ", "3Чтение ", "4Правка ", "5Копия ", "6НовИмя", "7НовКат", "8Удал-е", "9Меню  ", "0Выход " };
            foreach (string word in words)
            {

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[0])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(word[i]);

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }

                    if (word[i] == word[0]) continue; 
                    Console.Write(word[i]);
                    


                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            Console.SetCursorPosition(6, 16);
        }
    }



}   

