using System;
using System.Collections.Generic; 
using System.Linq;   
using System.Text;   
using System.Threading.Tasks;   

namespace stringText
{
	class Program
	{
		static void Main(Strings[] args) 
		{
			string myString = string.Format("{0:(###) ###-####}", 1234567890);
			
			//myString = String.Format("Length before: {0} -- Length After: {1}", myString.Length, myString.Trim().Length);

			Console.WriteLine(myString);
			Console.ReadLine();			
		}
		
	}
}

 
