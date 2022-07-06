using System;
using System.Collections.Generic;
using System.IO;
using AccessСontrol.AdminScripts;
using AccessСontrol.Enam;
using AccessСontrol.UserScripts;


namespace AccessСontrol
{
	public class Identification
	{
		public void Ident(string loginUser, string passwordUser)
		{
			if (CheckLogin(loginUser) && CheckPassword(loginUser, passwordUser)) {
				if (RepositoryUser.USER_COLLECTION[loginUser] == TypeUser.USER) {
					UserModel userModel = new UserModel(loginUser);
				} else if (RepositoryUser.USER_COLLECTION[loginUser] == TypeUser.ADMIN) {
					Administrator administrator = new Administrator();
				}
				Console.WriteLine($"Вы вошли как: {loginUser}\n" + $"C правами: {RepositoryUser.USER_COLLECTION[loginUser]}");
				return;
			}
			Console.WriteLine("Неправильное имя пользователя или пароль!");
		}
		private bool CheckLogin(string login)
		{
			foreach (KeyValuePair<string, TypeUser> id in RepositoryUser.USER_COLLECTION) {
				if (id.Key == login) {
					return true;
				}
			}
			return false;
		}
		private bool CheckPassword(string login, string pass)
		{
			return RepositoryUser.PASSWORD_COLLECTION[login] == pass;
		}
	}
}