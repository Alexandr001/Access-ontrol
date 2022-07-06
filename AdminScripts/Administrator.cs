using System;
using System.Collections.Generic;
using AccessСontrol.Enam;
using AccessСontrol.UserScripts;

namespace AccessСontrol.AdminScripts
{
	public class Administrator
	{
		public void AssignmentRights()
		{
			if (UserVerification(UserSelection())) {
				PrintAccess();
			}
		}

		public void ModeSelection()
		{
			Console.WriteLine("Введите режим:\n" + " 1 - Добваить права\n" + "2 - Удалить права");
			int mode = Convert.ToInt32(Console.ReadLine());
			switch (mode) {
				case 1:
					AddRight(Convert.ToInt32(Console.ReadLine()));
					break;
				case 2:
					RemoveRight(Convert.ToInt32(Console.ReadLine()));
					break;
				default:
					throw new Exception("Нет такого режима работы");
			}
		}
		
		private string UserSelection()
		{
			Console.WriteLine("Введите имя пользователя:");
			string user = Console.ReadLine();

			if (UserVerification(user)) {
				UserModel userModel = new UserModel(user);
				return user;
			}
			return null;
		}
		private bool UserVerification(string login)
		{
			foreach (KeyValuePair<string, List<int>> repor in RepositoryUser.ACCESS_COLLECTION) {
				if (repor.Key == login) {
					return true;
				}
			}
			return false;
		}

		private void PrintAccess()
		{
			Console.WriteLine("1 - Чтение\t" + "2 - Запись\n"
			                  + "3 - Создание\t" + "4 - Удаление\n"
			                  + "5 - Копирование\t" + "6 - Перемещение");
			
			Console.WriteLine($"Пользователю ({UserModel.TypeUser}) доступны следующие права:");
			foreach (int accessUser in UserModel.AccessUser) {
				Console.Write($"{accessUser}\t");
			}
		}

		private void AddRight(int right)
		{
			List<int> repositoryUserAccess = RepositoryUser.ACCESS_COLLECTION[UserModel.LoginUser];
			repositoryUserAccess.Add(right);
		}
		private void RemoveRight(int right)
		{
			List<int> repositoryUserAccess = RepositoryUser.ACCESS_COLLECTION[UserModel.LoginUser];
			repositoryUserAccess.Remove(right);
		}
	}
}