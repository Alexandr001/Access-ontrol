using System;
using System.Collections.Generic;
using System.IO;
using AccessСontrol.Enam;

namespace AccessСontrol
{
	public class IdentificationUser
	{
		private readonly Repository _repository = new Repository();
		private UserModel _userModel;
		
		public void Ident(string loginUser, string passwordUser)
		{
			if (CheckLogin(loginUser) && CheckPassword(loginUser, passwordUser)) {

				_userModel = new UserModel(loginUser,
				                           _repository.userCollection[loginUser],
				                           loginUser,
				                           _repository.accessCollection[loginUser]);
				Console.WriteLine($"Вы вошли как: {loginUser}\n" + $"C правами: {_repository.userCollection[loginUser]}");
				return;
			}
			Console.WriteLine($"Неправильное имя пользователя или пароль!");
		}
		public void CreateFolder() => Directory.CreateDirectory(UserModel.HomeFolder);
		private bool CheckLogin(string login)
		{
			foreach (KeyValuePair<string, TypeUser> id in _repository.userCollection) {
				if (id.Key == login) {
					return true;
				}
			}
			return false;
		}
		private bool CheckPassword(string login, string pass)
		{
			return _repository.passwordCollection[login] == pass;
		}
	}
}