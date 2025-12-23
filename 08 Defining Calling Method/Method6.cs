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
			
			Console.Write("Give Some Special Signed : ");
			string signed = Console.ReadLine();
			
			Console.Write("Results : ");		
			string reversedFirstText = ReverseString(firstText);
			string reversedSecondText = ReverseString(secondText);
			string reversedSigned = ReverseString(signed);
			
			Console.Write(String.Format("{0} {1} {2}", reversedFirstText, reversedSecondTExt, reversedSigned));
			
			Console.ReadLine();
		}
		
		private static string ReverseString(string message)
		{		
			char[] messageArray = message.ToCharArray();			
			Array.Reverse(messageArray);
			
			return String.Concat(messageArray);	
		}
		
	}
}
