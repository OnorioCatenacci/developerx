<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var t = new Manufacturing.Nested.table();
	var t2 = new Database.table();

	t.SayWhoIAm();
	t2.SayWhoIAm();

}
}  //Only necessary to make this code work under LinqPad.

namespace Manufacturing
{
	namespace Nested
	{
		public class table
		{
			public void SayWhoIAm()
			{
				Type tableType = typeof(table);
				System.Console.WriteLine("I am the table class in the {0} namespace",tableType.Namespace);
			}
		}
	}
}

namespace Database
{
	public class table
	{
		public void SayWhoIAm()
		{
			Type tableType = typeof(table);
			System.Console.WriteLine("I am the table class in the {0} namespace",tableType.Namespace);
		}
	}
}

class EOF{  //Only necessary to make this code work with LinqPad.  