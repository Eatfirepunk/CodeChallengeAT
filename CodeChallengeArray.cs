
// In this code challenge, you will need to re-arrange the order of strings within an array. An array will be passed with a collection of strings. The strings will be names' of individuals.
// A second array will be passed that includes the desired order of the strings. You will need to account for various size strings with varying order.
// You will return the reorganized array of strings.
// Sample strings:

// "Sonia Maria Wood Dempster"
// "Laruen Ana Eagles Beneke"
// Sample order array:
// order['4','1','2','3']

using System;
using System.Collections.Generic;
using System.Text;		
using System.Linq;

public class Program
{

	public static void Main()
	{
		string[] names1 = {"Sonia", "Maria" ,"Wood", "Dempster"};
		string[] names2 = { "Laruen", "Ana", "Eagles", "Beneke"};
		int[] order = {4,1,2,3,-1,5};
		
		//In this approach we just use string.join to print the newly ordered array
		//string.join has a overload that receives an IEnumerable so that way we don't need to create an extra method to print our ordered arrays
		// I extended the IEnumerable type with the method OrderWith which will take care of all the order logic and it will recive an IEnumerable<int>
		// with the desired order and will return us the re-ordered array
		Console.WriteLine(String.Join(",",names1.OrderWith(order)));
		Console.WriteLine(String.Join(",",names2.OrderWith(order)));
		
		// Why did i approach the challenge this way?
		//Because i feel it is small and compact very simplified and make use of great capabilities of C# and Linq
		
		//Check the other file in this github repo for another approach on this problem without using Linq or extension methods
	}

}

public static class Extensions 
{
	//OrderWith extension method  to simplify the looping 
        //You loop over the order, and for each item, grab the value at that index 
	// This problem seems like it can be tackled with linq in order to save us lines of code
        // Select linq method is a basicallly a foreach for an IEnumerable in this case the Indicies array will be our IEnumerable
        // But first im filtering the indicies array to avoid negative numbers or numbers outside of the bounds of the array
	// And finally we return the ordered array values which are making use of our extension method
     public static IEnumerable<T> OrderWith<T>(this T[] inputVal, IEnumerable<int> Indicies)
    {
        return Indicies.Where(idx=>idx >0 && idx <= inputVal.Count())
		.Select(idx=> inputVal[idx -1]);
    }
	
}
