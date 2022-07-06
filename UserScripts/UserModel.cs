using System.Collections.Generic;
using AccessСontrol.Enam;

namespace AccessСontrol
{
	public class UserModel
	{
		private const string PATH_PROJECT = "C:/Users/Adilya/RiderProjects/AccessСontrol/User/";

		public static TypeUser TypeUser { get; private set; }
		public static string HomeFolder { get; private set; }
		public static List<AccessUser> AccessUser { get; private set; }
		public static string LoginUser { get; private set; }

		public UserModel(string loginUser, TypeUser typeUser, string homeFolder, List<AccessUser> accessUser)
		{
			LoginUser = loginUser;
			TypeUser = typeUser;
			HomeFolder = PATH_PROJECT + homeFolder + "/";
			AccessUser = accessUser;
		}
	}
}