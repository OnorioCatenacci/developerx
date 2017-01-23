<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var flicka = new Mammal(new DateTime(2006,1,1),"Horse","Equus caballus",false);
	var flipper = new Mammal(new DateTime(1964,1,1),"Bottlenose Dolphin","Tursiops truncatus", true);
	var cherami = new Avian(new DateTime(1915,1,1),"Racing Pigeon","Columba livia", true);
	var gijoe = new Avian(new DateTime(1943,1,1),"Rock Dove","Columba livia livia", true);

    List<Animal> menagerie = new List<Animal>();
	menagerie.Add(flicka);
	menagerie.Add(flipper);
	menagerie.Add(cherami);
	menagerie.Add(gijoe);
	
	var onlyavians =
		from m in menagerie
		where m._scientificName.StartsWith("Columba")
		select m;
	
	Console.WriteLine("There are {0} avians in the menagerie", onlyavians.Count());
	Console.WriteLine("The first avian in the menagerie is a {0}",onlyavians.FirstOrDefault()._species);
	Console.WriteLine("The scientific name of the last avian in the menagerie is {0}",onlyavians.LastOrDefault()._scientificName);
}

public class Animal
{
	public readonly DateTime dateOfBirth;
	public readonly String species;
	public readonly String scientificName;

	public Animal(DateTime dob, String Species, String ScientificName)
	{
		dateOfBirth = dob;
		species = Species;
		scientificName = ScientificName;
	}
}

public class Mammal : Animal
{
	private readonly Boolean aquatic;

	public Mammal(DateTime dob, String species, String scientificName, Boolean Aquatic) : base(dob, species, scientificName)
	{
		aquatic = Aquatic;
	}
}

public class Avian : Animal
{
	private readonly Boolean flying;

	public Avian(DateTime dob, String species, String scientificName, Boolean Flying) : base(dob, species, scientificName)
	{
		flying = Flying;
	}
}