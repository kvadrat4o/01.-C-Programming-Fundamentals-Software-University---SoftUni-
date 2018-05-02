﻿/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/24
 * Time: 9:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Debug_InstructionSet
{
	class Program
	{
		public static void Main(string[] args)
		{
			string opCode = Console.ReadLine();

	        while (opCode != "end")
	        {
	            string[] codeArgs = opCode.Split(' ');
	
	            long result = 0;
	            switch (codeArgs[0])
	            {
	                case "INC":
	                    {
	                        int operandOne = int.Parse(codeArgs[1]);
	                        result = operandOne++;
	                        break;
	                    }
	                case "DEC":
	                    {
	                        int operandOne = int.Parse(codeArgs[1]);
	                        result = operandOne--;
	                        break;
	                    }
	                case "ADD":
	                    {
	                        int operandOne = int.Parse(codeArgs[1]);
	                        int operandTwo = int.Parse(codeArgs[2]);
	                        result = operandOne + operandTwo;
	                        break;
	                    }
	                case "MLA":
	                    {
	                        int operandOne = int.Parse(codeArgs[1]);
	                        int operandTwo = int.Parse(codeArgs[2]);
	                        result = (long)(operandOne * operandTwo);
	                        break;
	                    }
	            }
	
	            Console.WriteLine(result);
	        }
		}
	}
}