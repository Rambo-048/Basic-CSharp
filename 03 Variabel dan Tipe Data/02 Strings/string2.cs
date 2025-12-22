using System;
using System.Collections.Generic; 
using System.Linq;   
using System.Text;   
using System.Threading.Tasks;   

namespace inputText
{
	class Program
	{
		static void Main(Strings[] args) 
		{
			String firstName;
			String lastName;
			
			Console.WriteLine("What is Your Name?");
			
			Console.Write("Insert First Name : ");
			firstName = Console.Readline();

			Console.Write("Insert Last Name : ");
			lastName = Console.Readline();

			Console.WriteLine("Hello, " + firstName + " " + lastName);

		}
	}
}
