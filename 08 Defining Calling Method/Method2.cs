using System;
using System.Collections.Generic;   
using System.Linq;   
using System.Text; 
using System.Threading.Tasks; 

namespace helperMethod
{
	class Program
	{
		static void Main(Strings[] args) 
		{			
			ReverseString();
			Console.ReadLine();
		}
		
		private static void ReverseString()
		{
			string message = "Awali Harimu Dengan Senyuman, Jangan Lupa Sarapan";
			
			char[] messsageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			
			foreach (char item in messageArray)
			{
				Console.Write(item);
			}
		
		}
		
	}
}
