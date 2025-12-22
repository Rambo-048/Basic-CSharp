using System;
using System.Collections.Generic;   
using System.Linq;   
using System.Text;  
using System.Threading.Tasks;  

namespace littleSadButFunTime
{
	class Program
	{
		static void Main(Strings[] args) 
		{
			Console.WriteLine("= Kuis Lucu =");
			Console.WriteLine("Apa Warna Celana Bola Yang Menggoda Waktu Itu??");
			Console.WriteLine("1. Pinky Pink");
			Console.WriteLine("2. Hijau Stabilo");
			Console.WriteLine("3. Orange Juice");
			Console.Write("Choose One -> 1, 2 or 3 : ");
			String userValue = Console.ReadLine();

			if(userValue == "2")
			{
				String message = "HAHAHAHA... Yes, You're My Best Friend";
				Console.WirteLine(message);
			} else {
				Console.WriteLine("Whoopsy.. No");
			}
		}
	}
}
