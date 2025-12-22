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
			Console.WriteLine("Even You Don't Have Support From Some People In Your Life, You Must Keep Moving");
			
			Console.WriteLine("This is INPUT Function");
			Console.Write("Insert Your Name : ");

			String nama = Console.ReadLine();


			Console.WriteLine("Hello, {0} !!", nama);                       // <-- Menggunakan Placeholder
			Console.WriteLine($"Hello, {nama} Good Nite!!");          	// <-- Teknik String Interpolasi
			Console.WriteLine("Hello, " + nama + " Selamat Datang!!");      // <-- Concatenate			
		}
	}
}
