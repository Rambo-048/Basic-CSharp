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
				
			string myString = " Wherever You Go, Whatever You Do, May Your Guardian Watch Over You ";
			
			// myString = myString.Substring(6, 14);
			myString = myString.ToUpper();
			// myString = myString.Replace(" ", "--");
			// myString = myString.Remove(6, 14)

			Console.WriteLine(myString);
			Console.ReadLine();			
		}
		
	}
}

 
