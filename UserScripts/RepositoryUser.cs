using System;
using System.Collections.Generic;
using System.IO;
using AccessСontrol.Enam;

namespace AccessСontrol.UserScripts
{
	public static class RepositoryUser
	{
		private const string PATH_FOLDER = "C:/Users/Adilya/RiderProjects/AccessСontrol/Admin/";
		
		private const string ALEXANDER = "Alexander";
		private const string ADILYA = "Adilya";
		private const string ARTEM = "Artem";
		private const string POPOV = "Popov";
		
		public static readonly Dictionary<string, TypeUser> USER_COLLECTION = new Dictionary<string, TypeUser>() {
				[ALEXANDER] = TypeUser.USER,
				[ADILYA] = TypeUser.USER,
				[ARTEM] = TypeUser.USER,
				
				[POPOV] = TypeUser.ADMIN
		};

		public static readonly Dictionary<string, string> PASSWORD_COLLECTION = new Dictionary<string, string>() {
				[ALEXANDER] = "1234aaa",
				[ADILYA] = "1234bbb",
				[ARTEM] = "1234vvv",
				
				[POPOV] = "1234admin"
		};
		
		public static readonly Dictionary<string, List<int>> ACCESS_COLLECTION = new Dictionary<string, List<int>>() {
				[ALEXANDER] = ReadAccess(PATH_FOLDER + "Alexander.txt"),
				[ADILYA] = ReadAccess(PATH_FOLDER + "Adilya.txt"),
				[ARTEM] = ReadAccess(PATH_FOLDER + "Artem.txt"),
				
				[POPOV] = new List<int>() {
						(int) AccessUser.RECORD,
						(int) AccessUser.READING,
						(int) AccessUser.CREATURE,
						(int) AccessUser.REMOVAL,
						(int) AccessUser.COPYING,
						(int) AccessUser.MOVING
				}
		};

		private static List<int> ReadAccess(string path)
		{
			List<int> list = new List<int>();
			using (StreamReader reader = new StreamReader(path)) {
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					list.Add(Convert.ToInt32(line));
				}
			}
			return list;
		}
	}
}