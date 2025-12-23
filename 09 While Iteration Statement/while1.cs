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

			while(displayMenu == true)
			{
				displayMenu = MainMenu();
			}
		}


		private static void MainMenu()
		{
			Console.WriteLine("Choose A Text : ");
			Console.WriteLine("1. Text 1");
			Console.WriteLine("2. Text 2");
			Console.WriteLine("3. Text 3");
			Console.WriteLine("4. Text 4");
			Console.WriteLine("5. Text 5");
			Console.WriteLine("6. Exit");

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
				insertText3();
				return true;
			}
			else if (result == "4")
			{
				insertText4();
				return true;
			}
			else if (result == "5")
			{
				insertText5();
				return true;
			}
			else if (result == "6")
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
			Console.WriteLine("It Is Not The Place That Matters, It Is How Good You Are When You Get There");
			Console.ReadLine();
		}


		private static void insertText2()
		{
			Console.WriteLine("Enjoy The Ride, Enjoy The Moment");
			Console.ReadLine();
		}
		
		private static void insertText3()
		{
			Console.WriteLine("Wherever You Go, Whatever You Do, May Your Guardian Watch Over You");
			Console.ReadLine();
		}


		private static void insertText4()
		{
			Console.WriteLine("Spread Kindness Wherever You Go");
			Console.ReadLine();
		}
		
		private static void insertText5()
		{
			Console.WriteLine("It Is Not About The Past Or The Destination, It Is About The Journey");
			Console.ReadLine();
		}
	}
}


