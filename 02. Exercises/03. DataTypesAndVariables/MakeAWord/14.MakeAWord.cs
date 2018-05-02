/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/08
 * Time: 10:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MakeAWord
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			int n = int.Parse(Console.ReadLine());
			string result = null;
			for (int i = 0; i < n; i++) 
			{
				char input = char.Parse(Console.ReadLine());
				result += input;
			}
          Console.WriteLine("The word is: {0}",result);
		}
	}
}