using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab1
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Швидкість=");
			float speed = float.Parse(Console.ReadLine());
			Console.WriteLine("Прискорення=");
			float acceleration = float.Parse(Console.ReadLine());
			Console.WriteLine("Відстань=");
			float distance = float.Parse(Console.ReadLine());
			float time = (distance + acceleration) / (2 * speed);
			Console.WriteLine("Час=" + time);
		}
	}
}
