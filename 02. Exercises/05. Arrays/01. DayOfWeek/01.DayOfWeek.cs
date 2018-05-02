/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/25
 * Time: 9:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DayOfWeek
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int n = int.Parse(Console.ReadLine());
			string day = GetDay(n);
			Console.WriteLine(day);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string GetDay(int n)
		{
			string day = "Invalid Day!";
			string [] days = {"Monday" ,"Tuesday" ,"Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
			switch (n) 
			{
				case 1:
					
					return days[0];
				case 2:
					
					return days[1];
				case 3:
					
					return days[2];
				case 4:
					
					return days[3];
				case 5:
					
					return days[4];
				case 6:
					
					return days[5];
				case 7:
					
					return days[6];
				default: 
					return day;
			}
		}
	}
}