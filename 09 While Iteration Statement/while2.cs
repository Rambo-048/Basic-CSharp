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
			bool displayMenu = true;

			while(displayMenu)
			{
				displayMenu = MainMenu();
			}
		}


		private static void MainMenu()
		{
			// Console.Clear();

			Console.WriteLine("Choose A Text : ");
			Console.WriteLine("1. Text 1");
			Console.WriteLine("2. Text 2");
			Console.WriteLine("3. Exit");

			string result = Console.ReadLine();
			
			if (result == "1")
			{
				insertText1();
				return true;
			} 
			else if (result == "2")
			{
				insertText2();
				return true;
			}
			else if (result == "3")
			{
				return = false;
			}
			else
			{
				return = true;
			}
		}


		private static void insertText1()
		{
			// Console.Clear();

			Console.WriteLine("Enjoy The Ride, Enjoy The Moment");

			Console.Write("Type A Text : ");

			int result = int.Parse(Console.ReadLine());
			int counter = 1;

			while (counter < result)
			{
				Console.Write(counter);
				Console.Write("-");
				counter++;
			}

			Console.ReadLine();
		}


		private static void insertText2()
		{
			Console.WriteLine("Spread Kindness Wherever You Go");
			Console.ReadLine();
		}		
	}
}

