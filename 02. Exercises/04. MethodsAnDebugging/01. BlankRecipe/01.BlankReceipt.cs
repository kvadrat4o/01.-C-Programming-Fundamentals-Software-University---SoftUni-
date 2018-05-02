/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/17
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;
using System.Text;

namespace BlankReceipt
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			PrintReceipt();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void PrintReceipt()
			{
				PrintReceiptHeader();
				PrintReceiptBody();
				PrintReceiptFooter();
			}
		public static void PrintReceiptHeader()
			{
				Console.WriteLine("CASH RECEIPT");
				Console.WriteLine("------------------------------");
			}
		public static void PrintReceiptBody()
			{
				Console.WriteLine("Charged to____________________");
				Console.WriteLine("Received by___________________");
			}
		public static void PrintReceiptFooter()
			{
				Console.WriteLine("------------------------------");
				Console.WriteLine("\u00A9 SoftUni");
			}
			
		}
	}