using System;
using System.Collections.Generic;   
using System.Linq;  
using System.Text;   
using System.Threading.Tasks;   

namespace putSomeText
{
	class Program
	{
		static void Main(Strings[] args) 
		{	
			Console.Write("Insert First Text : ");
			string firstText = Console.ReadLine(); 	
			
			Console.Write("Insert Second Text : ");
			string secondText = Console.ReadLine();
			
			Console.WriteLine("Results : ");		
			ReverseString(firstText);
			ReverseString(secondText);
			
			Console.ReadLine();
		}
		
		private static void ReverseString(string message)
		{		
			char[] messageArray = message.ToCharArray();			
			Array.Reverse(messageArray);
			
			foreach (char item in messageArray)
			{
				Console.Write(item);
			}
			Console.Write(" ");
		}
		
	}
}

