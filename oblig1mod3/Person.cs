using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig1mod3
{
	public class Person
	{
		public int Id;
		public string FirstName;
		public string LastName;
		public int BirthYear;
		public int DeathYear;
		public Person Mother;
		public Person Father;

		public string GetDescription()
		{
			string response = string.Empty;
			if (FirstName != null) response += FirstName+" ";
			if (LastName != null) response += LastName+" ";
			if (Id > 0) response += "(Id="+Id+")";
			if (BirthYear > 0) response += " Født: "+BirthYear;
			if (DeathYear > 0) response += " Død: "+DeathYear;
			if (Father !=null) response+= " Far: "+Father.FirstName+" "+ "(Id=" + Father.Id + ")";
			if (Mother != null) response += " Mor: " + Mother.FirstName + " " + "(Id=" + Mother.Id + ")";
			return response;
		}
	}
}
