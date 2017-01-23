<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var flicka = new Mammal(new DateTime(2006,1,1),"Horse","Equus caballus",false);
	flicka.Move();
	
	var flipper = new Mammal(new DateTime(1964,1,1),"Bottlenose Dolphin","Tursiops truncatus", true);
	flipper.Move();
}

public class Animal
{
	private readonly DateTime dateOfBirth;
	private readonly String species;
	private readonly String scientificName;
	
	public Animal(DateTime dob, String Species, String ScientificName)
	{
		dateOfBirth = dob;
		species = Species;
		scientificName = ScientificName;
	}
}

public interface IMovement
{
	void Move();
}

public class Mammal : Animal, IMovement
{
	private readonly Boolean aquatic;
	
	public Mammal(DateTime dob, String species, String scientificName, Boolean Aquatic): base(dob, species, scientificName)
	{
		aquatic = Aquatic;
	}
	
	public void Move()
	{
		if (aquatic)
		{
			swim();
		}
		else
		{
			run();
		}
	}

	private void run()
	{
		Console.WriteLine("Run like the wind!");
	}
	
	private void swim()
	{
		Console.WriteLine("Swim like the tide!");
	}
}