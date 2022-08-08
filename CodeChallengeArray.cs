
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
		
		Console.WriteLine(String.Join(",",names1.OrderWith(order)));
		Console.WriteLine(String.Join(",",names2.OrderWith(order)));
	}

}

public static class Extensions 
{
	public static IEnumerable<T> OrderWith<T>(this T[] inputVal, IEnumerable<int> Indicies)
    {
        return Indicies.Where(idx=>idx >0 && idx <= inputVal.Count()).Select(idx=> inputVal[idx -1]);
    }
	
}