using System;
using System.Linq;
using System.Collections.Generic;


namespace HandsOfCards
{
	class HandsOfCards
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			var cards = new Dictionary<string,HashSet<int>>();
			var line = Console.ReadLine();
			while (line != "JOKER") 
			{
				var tokens = line.Split(':');
				var name = tokens[0];
				var cardsPowers = GetCardPowers();
				var cardsTypes = GetCardTypes();
				var playerCards = tokens[1].Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
				foreach (var card in playerCards) 
				{
					var cardPower = card.Substring(0, card.Length - 1);
					var cardType = card.Substring(card.Length - 1);
					var sum = cardsPowers[cardPower] * cardsTypes[cardType];
					if (!cards.ContainsKey(name)) 
					{
						cards[name] = new HashSet<int>();
					}
					cards[name].Add(sum);
				}
				
				
				line = Console.ReadLine();
			}
			foreach (var pair in cards) 
			{
					var name = pair.Key;
					var total = pair.Value.Sum();
					Console.WriteLine("{0}: {1}", name, total);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static Dictionary<string,int> GetCardPowers()
		{
			var powers = new Dictionary<string,int>();
			for (int i = 2; i <= 10; i++) 
			{
				powers[i.ToString()] = i;
			}
			powers["J"] = 11;
			powers["Q"] = 12;
			powers["K"] = 13;
			powers["A"] = 14;
			
			return powers;
		}
		public static Dictionary<string, int> GetCardTypes()
		{
			var cardTypes = new Dictionary<string,int>();
			cardTypes["S"] = 4;
			cardTypes["H"] = 3;
			cardTypes["D"] = 2;
			cardTypes["C"] = 1;
			
			return cardTypes;
		}
	}
}