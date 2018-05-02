/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/15
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace DragonArmy
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var dragons = new Dictionary <string, SortedDictionary<string, decimal[]>>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++) 
			{
				var tokens = Console.ReadLine().Split(' ');
				var type = tokens[0];
				var name = tokens[1];
				var damage = 0m;
				var health = 0m;
				var armour = 0m;
				if (tokens[2] != "null") 
				{
					damage = decimal.Parse(tokens[2]);
				}
				else
				{
					damage = 45;
				}
				if (tokens[3] != "null") 
				{
					health = decimal.Parse(tokens[3]);
				}
				else
				{
					health = 250;
				}
				if (tokens[4] != "null") 
				{
					armour = decimal.Parse(tokens[4]);
				}
				else
				{
					armour = 10;
				}
				if (!dragons.ContainsKey(type))
				{
					dragons[type] = new SortedDictionary<string, decimal[]>();
				}
					dragons[type][name] = new decimal[] {damage, health, armour};
				//tokens = Console.ReadLine().Split(' ');
			}
			
			foreach (var type in dragons) 
			{
				var typeName = type.Key;
				var dragonsByType = type.Value;
				var averageDamage = dragonsByType.Values.Average(x => x[0] );
				var averageHealth = dragonsByType.Values.Average(x => x[1] );
				var averageArmour = dragonsByType.Values.Average(x => x[2] );
				Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})",typeName,averageDamage,averageHealth,averageArmour);
				foreach (var dragon in dragonsByType) 
				{
					var name = dragon.Key;
					var stats = dragon.Value;
					var damage = stats[0];
					var health = stats[1];
					var armour = stats[2];
					Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",name,damage,health,armour);
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}