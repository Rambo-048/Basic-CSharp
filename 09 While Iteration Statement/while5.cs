using System;
using System.Collections.Generic;   
using System.Linq;  
using System.Text;   
using System.Threading.Tasks; 

namespace HelloHello 
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
			Console.Clear(); // <-----

			Console.WriteLine("Choose an Option : ");
			Console.WriteLine("1. Print Numbers");
			Console.WriteLine("2. Guessing Game");
			Console.WriteLine("3. Exit");

			string result = Console.ReadLine();
			
			if (result == "1")
			{
				PrintNumbers();   // <-- [1]
				return true;
			} 
			else if (result == "2")
			{
				GuessingGame();   // <-- [2]
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


		// [1]
		private static void PrintNumbers()
		{
			Console.Clear();

			Console.WriteLine("Print Numbers.!");

			Console.Write("Type a Number: ");

			int result = int.Parse(Console.ReadLine());
			int counter = 1;

			while (counter < result + 1) // <----
			{
				Console.Write(counter);
				Console.Write("-");
				counter++;
			}

			Console.ReadLine();
		}



		// [2]
		private static void GuessingGame()
		{	
			Console.Clear();

			Console.WriteLine("Guessing Game!");
			Console.ReadLine();

			Random myRandom = new Random();
			int randomNumber = myRandom.Next(1,11);

			int guesses = 0;
			bool incorrect = true;

			do
			{
				Console.WriteLine("Guess a Number between 1 and 10: ");

				string result = Console.ReadLine();

				guesses++;

				
				if (result == randomNumber.ToString())  
					incorrect = false;                 
				else                                   
					Console.WriteLine("Wrong!");       
				

			} while (incorrect);

			Console.WriteLine("Correct!! It took {0} Guesses.", guesses);

			Console.ReadLine();
		}		
	}
}

