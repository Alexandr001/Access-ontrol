using System.Collections.Generic;

namespace AccessСontrol
{
	public class Repository
	{
		public readonly Dictionary<string, TypeUser> userCollection = new Dictionary<string, TypeUser>() {
				["Alexander"] = TypeUser.USER,
				["Adilya"] = TypeUser.USER,
				["Artem"] = TypeUser.USER,
				["Popov"] = TypeUser.ADMIN
		};

		public readonly Dictionary<string, string> passwordCollection = new Dictionary<string, string>() {
				["Alexander"] = "1234aaa",
				["Adilya"] = "1234bbb",
				["Artem"] = "1234vvv",
				["Popov"] = "1234admin"
		};
		
		public readonly Dictionary<string, List<AccessUser>> accessCollection = new Dictionary<string, List<AccessUser>>() {
				["Alexander"] = new List<AccessUser>() {
						AccessUser.RECORD,
						AccessUser.READING,
						AccessUser.CREATURE,
						AccessUser.REMOVAL
				},
				["Adilya"] = new List<AccessUser>() {
						AccessUser.RECORD,
						AccessUser.READING,
						AccessUser.CREATURE,
						AccessUser.REMOVAL
				},
				["Artem"] = new List<AccessUser>() {
						AccessUser.RECORD,
						AccessUser.READING,
						AccessUser.CREATURE,
						AccessUser.REMOVAL
				},
				["Popov"] = new List<AccessUser>() {
						AccessUser.RECORD,
						AccessUser.READING,
						AccessUser.CREATURE,
						AccessUser.REMOVAL,
						AccessUser.COPYING,
						AccessUser.MOVING
				}
		};
	}
}