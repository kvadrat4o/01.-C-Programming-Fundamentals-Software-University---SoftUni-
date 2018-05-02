/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/24
 * Time: 9:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Debug_SubString
{
	class Program
	{
		public static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int jump = int.Parse(Console.ReadLine());
			const char Search = 'р';
			bool hasMatch = false;
	
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == Search)
				{
					hasMatch = true;
	
					int endIndex = jump;
	
					if (endIndex > text.Length)
					{
						endIndex = text.Length;
					}
	
					string matchedString = text.Substring(i, endIndex);
					Console.WriteLine(matchedString);
					i += jump;
				}
			}
	
			if (!hasMatch)
			{
				Console.WriteLine("no");
			}
		}
	}
}