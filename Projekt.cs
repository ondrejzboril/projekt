using System;
using System.Collections.Generic;

class Person
{
	public string name;
	public string surname;
	public string age;
	public string number;
	public Person(string n, string s, string a, string t)
	{
		this.name = n;
		this.surname = s;
		this.age = a;
		this.number = t;
	}

	public override string ToString()
	{
		return "Jméno:" + this.name + " Přijmení:" + this.surname + " Věk:" + this.age + " Telefonní číslo:" + this.number;
	}
}

public class Program
{
	public static void Main()
	{
		List<Person> persons = new List<Person>();
		bool running = true;
		while (running)
		{
			Console.WriteLine("----------------------------------");
			Console.WriteLine("Evidence pojištených");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("1. Přidat nového člověka");
			Console.WriteLine("2. Vypsat všechny");
			Console.WriteLine("3. Vyhledat pomocí jména a přijmení");
			Console.WriteLine("4. Konec");
			string answer = Console.ReadLine();
			if (answer.Equals("1"))
			{
				Console.WriteLine("Jméno:");
				string name = Console.ReadLine();
				Console.WriteLine("Přijmení:");
				string surname = Console.ReadLine();
				Console.WriteLine("Věk:");
				string age = Console.ReadLine();
				Console.WriteLine("Telefonní číslo:");
				string number = Console.ReadLine();
				Person person = new Person(name, surname, age, number);
				persons.Add(person);
				Console.WriteLine("Úspěšně přidáno");
				Console.WriteLine("Pro pokračování stiskni libovolnou klávesu.");
				Console.ReadLine();
			}

			if (answer.Equals("2"))
			{
				foreach (Person person in persons)
				{
					Console.WriteLine(person);
				}
				Console.WriteLine("Pro pokračování stiskni libovolnou klávesu.");
				Console.ReadLine();
			}

			if (answer.Equals("3"))
			{
				Console.WriteLine("Zadej jméno vyhledávaného:");
				string name = Console.ReadLine();
				Console.WriteLine("Zadej přijmení vyhledávaného:");
				string surname = Console.ReadLine();
				bool found = false;
				foreach (Person person in persons)
				{
					if (person.name.Equals(name))
					{
						if (person.surname.Equals(surname))
						{
							found = true;
							Console.WriteLine(person);
						}
					}
				}
				if (!found)
				{
					Console.WriteLine("V databázi není tento uživatel");
				}
				Console.WriteLine("Pro pokračování stiskni libovolnou klávesu.");
				Console.ReadLine();
			}

			if (answer.Equals("4"))
			{
				running = false;
			}
		}
	}
}