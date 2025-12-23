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
			
			StringBuilder myString = new StringBuilder();

			for (int i = 0; i < 100; i++)
			{
				myString.Append("--");
				myString.Append(i);

			}

			Console.WriteLine(myString);
			Console.ReadLine();			
		}
		
	}
}

 
