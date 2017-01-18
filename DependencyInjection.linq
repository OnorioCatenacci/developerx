<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var fs = new Foodstore();
	fs.StoreFood(500);
	var beast = new Animal(new DateTime(2006,1,1),"Horse","Equus caballus",fs);
	Console.WriteLine("We got {0} tons of food for our beast",beast.GetFood(400));
}

public class Animal
{
	private readonly DateTime _dateOfBirth;
	private readonly String _species;
	private readonly String _scientificName;
	private readonly Foodstore _foodstore;  //Hold the injected dependency
	
	public Animal(DateTime dob, String species, String scientificName, Foodstore fs /*this is the dependency that is injected */)
	{
		_dateOfBirth = dob;
		_species = species;
		_scientificName = scientificName;
		_foodstore = fs;
	}
	
	public int GetFood(int foodRequested)
	{
		return (_foodstore.GetFood(foodRequested));
	}
}

public class Foodstore
{
	private int _tonsOfFoodAvailable;
	
	public Foodstore()
	{
		_tonsOfFoodAvailable = 0; 
	}

	public int GetFood(int foodRequested)
	{
		if (_tonsOfFoodAvailable <= 0)
		{
			return 0;
		}
		else
		{
			_tonsOfFoodAvailable = (_tonsOfFoodAvailable - foodRequested < 0) ? 0 : _tonsOfFoodAvailable -= foodRequested;
			return foodRequested;
		}
	}

	public void StoreFood(int foodPurchased)
	{
		_tonsOfFoodAvailable += foodPurchased;
	}
}