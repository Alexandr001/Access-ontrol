using System;
using System.Collections.Generic;
using AccessСontrol.Enam;
using AccessСontrol.UserScripts;

namespace AccessСontrol
{
	public class User
	{
		private File _file = new File();
		public void Test()
		{
			Console.WriteLine(UserModel.HomeFolder);
			Console.WriteLine("Выберите режим работы:\n" 
			                  + "1 - Чтение\t" + "2 - Запись\n"
			                  + "3 - Создание\t" + "4 - Удаление\n"
			                  + "5 - Копирование\t" + "6 - Перемещение");
			
			int operatingMode = Convert.ToInt32(Console.ReadLine());
			// Проверить есть ли такой файл
			string pathFile;
			switch (operatingMode) {
				case (int) AccessUser.READING:
					Console.WriteLine("Введите название файла:");
					pathFile = UserModel.HomeFolder + Console.ReadLine();
					_file.Open(pathFile);
					break;
				
				case (int) AccessUser.RECORD:
					Console.WriteLine("Введите название файла:");
					pathFile = UserModel.HomeFolder + Console.ReadLine();
					Console.WriteLine("Введите текст для записи:");
					string text = Console.ReadLine();
					_file.Record(pathFile, text);
					break;
				
				case (int) AccessUser.CREATURE:
					Console.WriteLine("Введите имя файла:");
					pathFile = UserModel.HomeFolder + Console.ReadLine();
					Console.WriteLine(UserModel.HomeFolder);
					_file.Create(pathFile);
					break;
				
				case (int) AccessUser.REMOVAL:
					Console.WriteLine("Введите имя файла:");
					pathFile = UserModel.HomeFolder + Console.ReadLine();
					_file.Remove(pathFile);
					break;
				
				case (int) AccessUser.COPYING:
					Console.WriteLine("Введите имя файла:");
					pathFile = UserModel.HomeFolder + Console.ReadLine();
					Console.WriteLine("Введите путь к папке для копирования:");
					string pathCopy = Console.ReadLine();
					_file.Copy(pathFile, pathCopy);
					break;
				
				case (int) AccessUser.MOVING:
					Console.WriteLine("Введите имя файла:");
					pathFile = UserModel.HomeFolder + Console.ReadLine();
					Console.WriteLine("Введите путь к папке для Перемещения:");
					string pathMove = Console.ReadLine();
					_file.Move(pathFile, pathMove);
					break;
					
				default:
					Console.WriteLine("Нет такого режима работы!!!");
					break;
			}
			
		}
	}
}