<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var d = new DelegateAndLambda();
	d.DisplayTheMultiplicationResult();
	d.DisplayTheAdditionResult();
	
}

public class DelegateAndLambda
{
	// This declares that an IntegerOperation delegate will
	// be a function that takes two integer parameters and 
	// returns an integer value. 
	public delegate int IntegerOperation(int n, int m);
	
	//PerformOurOperation takes a function which conforms to the IntegerOperation delegate's specification
	public int PerformOurOperation(IntegerOperation i)
	{
		return i.Invoke(3, 4);
	}

	public void DisplayTheMultiplicationResult()
	{
		//(int n, int m) => { return n * m;} is a lambda. An anonymous function which takes two integer parameters
		// and returns an integer result (n * m).  This meets the specification for IntegerOperation. 
		Console.WriteLine("PerformOurOperation returned {0}", PerformOurOperation((int n, int m) => { return n * m;}));
	}
	
	public void DisplayTheAdditionResult()
	{
		//(int n, int m) => { return n + m;} is a different lambda which also meets the IntegerOperation specification.
		Console.WriteLine("PerformOurOperation returned {0}", PerformOurOperation((int n, int m) => { return n + m;}));
	}
}
