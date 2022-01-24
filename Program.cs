namespace Modul8_FinalTask3
{
    using System;
    using System.IO;

    class Program
    {
        public static void Main(string[] args)
        {
            // сохраняем путь к файлу (допустим, я его скачал на рабочий стол в тестовую директорию)
            string fileВinPath = @"C:\Users\wmtra\Desktop\TestDir\Students.dat";

            if (File.Exists(fileВinPath)) // при запуске проверим, что файл бинарный существует 
            {
                // строковая переменная, в которую будем считывать данные
                string stringValue;

                // считываем, после использования высвобождаем задействованный ресурс BinaryReader
                using (BinaryReader reader = new BinaryReader(File.Open(fileВinPath, FileMode.Open)))
                {
                    stringValue = reader.ReadString();

                }

                // Вывод
                Console.WriteLine("Из файла считано:");
                Console.WriteLine(stringValue);
            }
        }
    }

}