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
			Console.WriteLine("Type Some Text Here?");
			
			Console.Write("Insert First Text : ");
			String firstText;
			firstText = Console.Readline();

			Console.Write("Insert Second Text : ");
			String secondText;
			secondText = Console.Readline();

			Console.WriteLine("How Are You Feeling --> " + firstText + " " + secondText);

		}
	}
}
