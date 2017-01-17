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
	private readonly DateTime _dateOfBirth;
	private readonly String _species;
	private readonly String _scientificName;
	
	public Animal(DateTime dob, String species, String scientificName)
	{
		_dateOfBirth = dob;
		_species = species;
		_scientificName = scientificName;
	}
}

public interface IMovement
{
	void Move();
}

public class Mammal : Animal, IMovement
{
	private readonly Boolean _aquatic;
	
	public Mammal(DateTime dob, String species, String scientificName, Boolean Aquatic): base(dob, species, scientificName)
	{
		_aquatic = Aquatic;
	}
	
	public void Move()
	{
		if (!_aquatic)
		{
			Console.WriteLine("Run like the wind!");
		}
		else
		{
			Console.WriteLine("Swim like the tide!");
		}
	}
}