using System;
using System.Collections.Generic;
using AccessСontrol.Enam;
using AccessСontrol.UserScripts;

namespace AccessСontrol
{
	public class Administrator
	{
		private RepositoryUser _repositoryUser = new RepositoryUser();
		public string UserSelection()
		{
			Console.WriteLine("Введите имя пользователя:");
			string user = Console.ReadLine();

			if (UserVerification(user)) {
				UserModel userModel = new UserModel(user);
				return user;
			}
			return "Нет такого пользователя!";
		}
		public void AssignmentRights()
		{
			
		}
		private bool UserVerification(string login)
		{
			foreach (KeyValuePair<string, List<AccessUser>> repor in _repositoryUser.accessCollection) {
				if (repor.Key == login) {
					return true;
				}
			}
			return false;
		}
	}
}