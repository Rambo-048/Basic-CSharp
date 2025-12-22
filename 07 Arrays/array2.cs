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
		
			int[] numbers = new int[5];
			
			numbers[0] = 2;
			numbers[1] = 4;
			numbers[2] = 6;
			numbers[3] = 8;
			numbers[4] = 10;
			// numbers [5] = 12; <-- IndexOutOfRange was Unhandled(C#) / ArrayIndexOutOfBoundsException(JAVA)
	      
			// Console.WriteLine(numbers[2]);
			Console.WriteLine(numbers.length);
		}
	}
}

