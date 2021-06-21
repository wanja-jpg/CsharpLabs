using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
			int number;
			do
			{
				Console.WriteLine("number=");
				number = int.Parse(Console.ReadLine());
				if (number < 100 || number > 999)
				{
					Console.WriteLine("Невірне значення");
				}
			} while (number < 100 || number > 999);

			/*
			int fnum = number % 10;
			int snum = (number / 10) % 10;
			int tnum = (number / 100) % 10;
			*/
			if (number % 10 < (number / 10) % 10 && (number / 10) % 10 < (number / 100) % 10)
				Console.WriteLine("Послідовність зпадаюча");
			else if (number % 10 > (number / 10) % 10 && (number / 10) % 10 > (number / 100) % 10)
				Console.WriteLine("Послідовність зростаюча");
			else
				Console.WriteLine("Послідовність не зростаюча та не зпадаюча");
		}
    }
}
