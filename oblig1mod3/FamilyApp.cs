using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig1mod3
{
	public class FamilyApp
	{
		public string WelcomeMessage = "Welcome!";
		public string CommandPrompt = "Command: ";
		private List<Person> _people;
		public FamilyApp(params Person[] people)
		{
			_people = new List<Person>(people);
		}

		public string HandleCommand(string command)
		{
			var stringArray = command.Split(' ');
			string vs = stringArray[0];
			//string id = stringArray[1];
			if (vs == "help") {
				return "Write help for commands\nWrite list for list of all persons" +
				"\nWrite show <id> to show all details about a person";
			}
			if (vs == "list") {
				string listPeople = string.Empty;
				foreach (Person person in _people) {
					listPeople += "Name: " + person.FirstName + " Id: " + person.Id + "\n";

				}
				listPeople += "Type show <id> to see children";
				return listPeople;
			}
				if (vs == "show" && stringArray.Length > 1) {
				string listPeople = string.Empty;
				string thereIsAChild = string.Empty;
				//int numberOfChildren = 0;
				string children = string.Empty;
				int Id = Convert.ToInt32(stringArray[1]);
				Person findPerson = _people.Find(p => p.Id == Id);
				listPeople += findPerson.GetDescription()+"\n";
				foreach (Person person in _people)
				{
					if (person.Father == findPerson || person.Mother == findPerson)
					{
						thereIsAChild = "  Barn:\n";
						children += "    "+person.FirstName+" (Id="+person.Id+") Født: "+person.BirthYear+"\n";
					}
				}
				//HAHA HVEM SKULLE TRODD AT JEG FANT FUNKSJONELL KODE SOM FUNKET BAKLENGS AV DET JEG TRODDE OG VAR RIKTIG MUHAHAHA!!! :D
				//Person findFather = _people.Find(p => p.Father == findPerson);
				//Person findMother = _people.Find(p => p.Mother == findPerson);
				//Console.WriteLine("Is this your daddy? "+findFather.GetDescription());
				//Console.WriteLine("Is this your mommy? " + findMother.GetDescription());

				return listPeople+thereIsAChild+children;
				}
				
			return "Write help or list";
			}
		}
	}
