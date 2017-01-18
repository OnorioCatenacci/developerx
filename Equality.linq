<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var xcoordinate = 1;
	var ycoordinate = 1;
	
	Point p1 = new Point(xcoordinate,ycoordinate);
	Point p2 = new Point (1,1);
	
	// Important takeaway: == is a REFERENCE comparison, not a VALUE comparison.
	// Just be careful about which one you use!
	Console.WriteLine("xcoordinate == ycoordinate is {0}",xcoordinate == ycoordinate);
	Console.WriteLine("p1 == p2 is {0}",p1==p2);
	Console.WriteLine("p1.Equals(p2) is {0}",p1.Equals(p2));
	
	//This sets both objects to reference the same memory.  Hence == will return a true at this point.
	p1 = p2;
	Console.WriteLine("p1 == p2 (after assignment) is {0}", p1==p2);
	Console.WriteLine("p1.Equals(p2) (after assignment) is {0}",p1.Equals(p2));
}

class Point : Object
{
	protected int x, y;

	public Point(int xValue, int yValue)
	{
		x = xValue;
		y = yValue;
	}
	public override bool Equals(Object obj)
	{
		// Check for null values and compare run-time types.
		if (obj == null || GetType() != obj.GetType())
			return false;

		Point p = (Point)obj;
		return (x == p.x) && (y == p.y);
	}
	public override int GetHashCode()
	{
		return x ^ y;
	}
}