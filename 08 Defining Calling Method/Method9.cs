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
		
			
			Console.WriteLine("HELPER METHOD");
			
						
			Console.Write("Nama Depan : ");
			string firstName = Console.ReadLine(); 	
			
			Console.Write("Nama Belakang : ");
			string lastName = Console.ReadLine();
			
			Console.Write("In What City Were You Born : ");
			string city = Console.ReadLine();
			
			
			
			char[] firstNameArray = firstName.ToCharArray();
			Array.Reverse(firstNameArray);
			
			char[] lastNameArray = lastName.ToCharArray();
			Array.Reverse(lastNameArray);
			
			char[] cityArray = city.ToCharArray();
			Array.Reverse(cityArray);
			
			
			
			String result = "";
			
						
			
			
			foreach (char item in firstNameArray)
			{
				result += item;
			}
			
			foreach (char item in lastNameArray)
			{
				result += item;
			}
			
			foreach (char item in cityArray)
			{
				result += item;
			}
			
			Console.WriteLine("Results : " + result);
		}		
	}
}

