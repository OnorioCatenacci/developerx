<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

public class TestClass
{
	private int _member1;
	private string _member2;

	TestClass()  //The default constructor (no parameters).  Note visibility is _private_ by default.
	{
		_member1 = 1000;
		_member2 = "";
	}

	public TestClass(int m1_value)  //A public constructor that specifies member1's value.  Note that like any other method constructors can be (and often are) overloaded.
	{
		_member1 = m1_value;
		_member2 = "";
	}

	public TestClass(int m1_value, string m2_value) : this(m1_value)
	{
		_member2 = m2_value;
	}
	
	public TestClass(string m2_value): this()
	{
		_member2 = m2_value;
	}
	
	public void ExamineValues()
	{
		Console.WriteLine("_member1 is " + _member1.ToString());
		Console.WriteLine("_member2 is " + _member2);
	}
}

void Main()
{
	//TestClass zerothInstance = new TestClass(); //This will throw an error because the default constructor is private.
	TestClass firstInstance = new TestClass(1);  //note that we can also sometimes use "var" rather than the name of the class.
	firstInstance.ExamineValues();
	var secondInstance = new TestClass(2, "String1");
	secondInstance.ExamineValues();
	{
		var thirdInstance = new TestClass("String2");
		thirdInstance.ExamineValues();
	} //Note that at this point e is out of scope.  The end of e's life cycle.
}