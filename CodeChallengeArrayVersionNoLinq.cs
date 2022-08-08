using System;
using System.Collections.Generic;
using System.Text;					
public class Program
{

	public static void Main()
	{
		string[] names1 = {"Sonia", "Maria" ,"Wood", "Dempster"};
		string[] names2 = { "Laruen", "Ana", "Eagles", "Beneke"};
		int[] order = {4,1,2,3};
		
		printList(reOrderedArray(names1,order));
		printList(reOrderedArray(names2,order));
		
		// note i've noticed that the order array in the example is composed of a char array
		// so on the reOrderedArray method instead of looping through an int[] it will be on a char[]
		// and i will convert the num on each iteration from char to int	
			
		//public static string[] reOrderedArray(string[] originalList, char[] order)
		//{ 
		//	string[] orderedList = new string[originalList.Length];
		//	int count = 0;
		//	foreach(char num in order)
		//	{
		//		orderedList[count] = originalList[int.Parse(num.ToString()) - 1];
		//		count++;
		//	}
		//	
		//	return orderedList;
		//}
		
		
	}
	
	public static string[] reOrderedArray(string[] originalList, int[] order)
	{ 
		string[] orderedList = new string[originalList.Length];
		int count = 0;
		foreach(int num in order)
		{
			orderedList[count] = originalList[num - 1];
			count++;
		}
		
		return orderedList;
	}
	
	public static void printList(string[] list)
		{ 
			StringBuilder sb = new StringBuilder();
			foreach(string num in list)
			{
				sb.Append(num + " ");
			}
			Console.WriteLine(sb.ToString());
		}
	
	
}