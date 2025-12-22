using System;
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  

namespace someText
{
	class Program
	{
		static void Main(Strings[] args) 
		{			
		
			string text = "Not Really A Good Day" + "But Always Have A Something Good In Everyday";
			
			char[] charArray = text.ToCharArray();
			Array.Reverse(charArray);
			
			foreach (char textChar in charArray)
			{
				Console.Write(textChar);
			}
		}
	}
}
