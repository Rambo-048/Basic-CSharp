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
			string message = "Today Is A Bad Day?? Oh My God.. Where Is My Guitar";
			
			char[] messsageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			
			foreach (char item in messageArray)
			{
				Console.Write(item);
			}
		
		}
		
	}
}
