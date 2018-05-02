/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 5:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace SplitByWord
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
		List<string> input = Console.ReadLine().Split(new char[] {',',';',':','.','!','(',')','\'','"','\\','/','[',']',' '},StringSplitOptions.RemoveEmptyEntries).ToList();
		SplitByWord(input);
		
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void SplitByWord(List<string> input)
		{
			List<string> upper = new List<string>();
			List<string> lower = new List<string>();
			List<string> mixed = new List<string>();
			foreach (var i in input) 
			{
				var w = GetInputType(i);
				if (w == InputType.Uppercase) 
				{
					upper.Add(i);
				}
				else if (w == InputType.Lowercase) 
				{
					lower.Add(i);
				}
				else 
				{
					mixed.Add(i);
				}
			}
			PrintLists(upper,lower,mixed);
		}
		enum InputType {Uppercase, Lowercase,Mixedcase};
		
		
		 static InputType GetInputType(string i)
		{
			int lowerCounter = 0;
			int upperCounter = 0;
			foreach (var l in i) 
			{
				if (char.IsUpper(l)) 
				{
					upperCounter++;
				}
				else if (char.IsLower(l)) 
				{
					lowerCounter++;
				}
			}
			if (upperCounter==i.Length) 
			{
				return InputType.Uppercase;
			}
			else if (lowerCounter==i.Length) 
			{
				return InputType.Lowercase;
			}
			else 
			{
				return InputType.Mixedcase;
			}
		}
		public static void PrintLists(List<string> upper, List<string> lower, List<string> mixed)
		{
			Console.WriteLine("Lower-case: {0}\nMixed-case: {1}\nUpper-case: {2}",String.Join(", ",lower),String.Join(", ",mixed),String.Join(", ",upper));
		}
	}
}