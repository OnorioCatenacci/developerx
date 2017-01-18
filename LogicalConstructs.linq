<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	//Ternary operator
	var dob = new DateTime(1901, 1, 1);
	var dob2 = new DateTime(1921, 1, 1);
	var bornlater = dob > dob2 ? dob : dob2;    //Beware the null!
	Console.WriteLine("bornlater is {0}", bornlater.ToString());

	dob = new DateTime(1950,1,1);
	//if-else
	if (dob > dob2)
	{  //Note USFS coding standard.  If branch and else branch are _always_ statement blocks.  
		Console.WriteLine("bornlater is {0}", dob.ToString());
	}
	else
	{
		Console.WriteLine("bornlater is {0}", dob2.ToString());
	}

	dob = new DateTime(1921,1,1);
	//Switch case.  We wouldn't bother with a switch case with something this simple. 
	switch (dob > dob2)
	{
		case true:
			{
				Console.WriteLine("bornlater is {0}", dob.ToString());
				break;
			}
		default:
			{
				Console.WriteLine("bornlater is {0}", dob2.ToString());
				break;
			}
	}
	
	//Not really a logical operator but still worth seeing.  The null-coalescing operator (??)
	
	const string defaultCity = "Troy";
	
	string City = null;
	
	var ClientCity = City ?? defaultCity;  //if city is not null then return city else return the value after the ??
	Console.WriteLine("ClientCity is {0}", ClientCity);

	City = "Clarkston";	
	ClientCity = City ?? defaultCity;
	Console.WriteLine("ClientCity is {0}", ClientCity);
}