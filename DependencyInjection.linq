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
	private readonly DateTime dateOfBirth;
	private readonly String species;
	private readonly String scientificName;
	private readonly Foodstore foodstore;  //Hold the injected dependency
	
	public Animal(DateTime dob, String Species, String ScientificName, Foodstore fs /*this is the dependency that is injected */)
	{
		dateOfBirth = dob;
		species = Species;
		scientificName = ScientificName;
		foodstore = fs;
	}
	
	public int GetFood(int foodRequested)
	{
		return (foodstore.GetFood(foodRequested));
	}
}

public class Foodstore
{
	private int tonsOfFoodAvailable;
	
	public Foodstore()
	{
		tonsOfFoodAvailable = 0; 
	}

	public int GetFood(int foodRequested)
	{
		if (tonsOfFoodAvailable <= 0)
		{
			return 0;
		}
		else
		{
			tonsOfFoodAvailable = (tonsOfFoodAvailable - foodRequested < 0) ? 0 : tonsOfFoodAvailable -= foodRequested;
			return foodRequested;
		}
	}

	public void StoreFood(int foodPurchased)
	{
		tonsOfFoodAvailable += foodPurchased;
	}
}