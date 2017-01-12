namespace USFS.DeveloperX
{
	using System;
	using System.Diagnostics; 

	public class UnitTestDemo
	{
		public static int Main(string[] args)
		{
			Console.WriteLine("Running unit tests");
			UnitTestDemo.RunUnitTest();
			return 0;
		}

		private static void RunUnitTest()
		{
			var a = 3;
			var b = 4;

			TestAssertion(MultiplyThemNumbers(a,b), 12, "Multiplication Succeeded", "Multiplication failed");
		}

		private static int MultiplyThemNumbers(int n, int m)
		{
			return n * m; 
		}

		private static void TestAssertion(Object expected, Object actual, string trueMessage, string falseMessage)
		{
			if(expected.Equals(actual))
			{
				Console.WriteLine(trueMessage);
			}
			else
			{
				Console.WriteLine(falseMessage);
			}
		}
	}
}