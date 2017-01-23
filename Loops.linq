<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
//	var l = new List<Int16> { 1, 2, 3, 4, 5, 6};
	var l = new List<string> {"Hi","Hola","Ciao","Hallo","Здравствуйте"};

	//For loop
	//NB: be extra careful with the test.
	// 1.) Insure you're testing against the correct size of the collection
	// 2.) Insure you use either "less than" or "less than or equal" depending on what you're looping over. 
	for (int n = 0; n < l.Count(); n++)     
	{
		Console.WriteLine("For Loop: Element {0} is {1}", n, l[n]);
	}

	Console.WriteLine("");
	
	//While loop
	int i = 0;
	while (i < l.Count)
	{
		Console.WriteLine("While Loop: Element {0} is {1}", i, l[i]);
		i++;  //Don't forget this in a while loop otherwise the loop will run indefinitely!
	}

	Console.WriteLine("");

	//Do while loop
	int j = 0;
	do
	{
		Console.WriteLine("Do While Loop: Element {0} is {1}", j, l[j]);
	}
	while (++j < l.Count());
	// NB: we increment j _before_ we test it against l.Count.  
	// This is another thing to be careful about!

	Console.WriteLine("");

//	foreach (int fe in l)  //NB: we must declare the index variable to be the correct type!
//	{
//		Console.WriteLine("Foreach Loop: fe is {0}", fe);
//	}

	foreach (string fe in l)  //NB: we must declare the index variable to be the correct type!
	{
		Console.WriteLine("Foreach Loop: fe is {0}", fe);
	}

	// Main point here: if you can use LINQ to accomplish what you would do with a loop, use LINQ.  Otherwise just be 
	// careful about looping code.  It's tricky for almost every developer. 
}