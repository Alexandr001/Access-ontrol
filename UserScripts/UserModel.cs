using System.Collections.Generic;
using System.IO;
using AccessСontrol.Enam;

namespace AccessСontrol.UserScripts
{
	public class UserModel
	{
		private const string PATH_PROJECT = "C:/Users/Adilya/RiderProjects/AccessСontrol/User/";

		public static TypeUser TypeUser { get; private set; }
		public static string HomeFolder { get; private set; }
		public static List<int> AccessUser { get; set; }
		public static string LoginUser { get; private set; }

		public UserModel(string loginUser)
		{
			LoginUser = loginUser;
			TypeUser = RepositoryUser.USER_COLLECTION[loginUser];
			HomeFolder = PATH_PROJECT + loginUser + "/";
			AccessUser = RepositoryUser.ACCESS_COLLECTION[loginUser];
			
			CreateFolder();
		}
		
		private void CreateFolder() => Directory.CreateDirectory(UserModel.HomeFolder);
	}
}