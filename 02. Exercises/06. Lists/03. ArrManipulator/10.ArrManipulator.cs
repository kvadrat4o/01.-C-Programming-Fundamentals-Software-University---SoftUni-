/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/06/09
 * Time: 2:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
	
	
namespace ArrManipulator
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			List<double> inputNums = Console.ReadLine().Split(' ').Select(x=>double.Parse(x)).ToList();
			ManipulateArray(inputNums);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void ManipulateArray(List<double> inputNums)
		{
                var input = Console.ReadLine().Split(' ').ToList();
                while(input[0] != "print")
                {
                    int index = 0;
                    int element = 0;
                    int end = inputNums.Count;
                   switch (input[0])
                   {
                        case "add":
                            index = (int.Parse)(input[1]);
                            if (index > inputNums.Count)
                                break;
                            element = (int.Parse)(input[2]);
                            inputNums.Insert(index, element);
                            break;
                        case "addMany":
                            index = (int.Parse)(input[1]);
                            if (index > inputNums.Count)
                                break;
                            for (int i = input.Count - 1; i >= 2; i--)
                                inputNums.Insert(index, (int.Parse)(input[i]));
                            break;
                        case "contains":
                            element = (int.Parse)(input[1]);
                            Console.WriteLine(inputNums.IndexOf(element));
                            break;
                        case "remove":
                            index = (int.Parse)(input[1]);
                            inputNums.RemoveAt(index);
                            break;
                        case "shift":
                            index = (int.Parse)(input[1])%inputNums.Count;
                            var result = inputNums.Skip(index).ToList();
                            for (int i = 0; i < index; i++)
                                result.Add(inputNums[i]);
                            inputNums = result;
                            break;
                        case "sumPairs":
                            List<double> sums = new List<double>();
                            if (inputNums.Count % 2 != 0)
                                end = inputNums.Count - 1;
                           
                            for (int i = 0; i < end; i+=2)
                                sums.Add(inputNums[i] + inputNums[i + 1]);
                            if (inputNums.Count % 2 != 0)
                                sums.Add(inputNums.Last());
                            inputNums = sums;
                            break;
                        default: Console.WriteLine(); break;
                    }
                    input = Console.ReadLine().Split(' ').ToList();
                }
                Console.WriteLine("[" + string.Join(", ", inputNums) + "]");
               
            }
     }
}
