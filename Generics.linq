<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var flicka = new Mammal(new DateTime(2006,1,1),"Horse","Equus caballus",false);
	var flipper = new Mammal(new DateTime(1964,1,1),"Bottlenose Dolphin","Tursiops truncatus", true);
	var cherami = new Avian(new DateTime(1915,1,1),"Rock Dove","Columba livia", true);

	var menagerie = new List<Animal>();
	menagerie.Add(flicka);
	menagerie.Add(flipper);
	menagerie.Add(cherami);
	
	Console.WriteLine("There are {0} animals in the menagerie", menagerie.Count());
	Console.WriteLine("The first animal in the menagerie is a {0}",menagerie[0]._species);
	Console.WriteLine("The scientific name of the last animal in the menagerie is {0}",menagerie[2]._scientificName);
}

public class Animal
{
	public readonly DateTime _dateOfBirth;
	public readonly String _species;
	public readonly String _scientificName;

	public Animal(DateTime dob, String species, String scientificName)
	{
		_dateOfBirth = dob;
		_species = species;
		_scientificName = scientificName;
	}
}

public class Mammal : Animal
{
	private readonly Boolean _aquatic;

	public Mammal(DateTime dob, String species, String scientificName, Boolean Aquatic) : base(dob, species, scientificName)
	{
		_aquatic = Aquatic;
	}
}

public class Avian : Animal
{
	private readonly Boolean _flying;

	public Avian(DateTime dob, String species, String scientificName, Boolean flying) : base(dob, species, scientificName)
	{
		_flying = flying;
	}
}