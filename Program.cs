using System;

namespace AccessСontrol
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите имя пользователя и пароль:");

			IdentificationUser ident = new IdentificationUser();
			ident.Ident(Console.ReadLine(), Console.ReadLine());
			ident.CreateFolder();

			User user = new User();
			user.Test();

		}
	}
}