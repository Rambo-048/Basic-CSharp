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
			String firstText;
			String secondText;
			
			Console.WriteLine("Type Some Text Here?");
			
			Console.Write("Insert First Text : ");
			firstText = Console.Readline();

			Console.Write("Insert Second Text : ");
			secondText = Console.Readline();

			Console.WriteLine("How Are You Feeling --> " + firstText + " " + secondText);

		}
	}
}
