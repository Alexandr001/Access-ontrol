using System;

namespace AccessСontrol
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите имя пользователя и пароль:");

			Identification ident = new Identification();
			ident.Ident(Console.ReadLine(), Console.ReadLine());

			User user = new User();
			user.Test();

		}
	}
}