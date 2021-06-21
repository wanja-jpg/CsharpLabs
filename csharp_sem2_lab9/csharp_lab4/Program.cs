using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.WriteLine("N=");
                N = int.Parse(Console.ReadLine());
                if(N < 0)
                {
                    Console.WriteLine("Неверное значение N");
                }
            } while (N < 0);

            const int max_value = 100;
            const int min_value = 0;
            int[] array = new int[N];
            Random rnd = new Random();
            for (int r_count = 0;r_count < N; r_count++)
            {
                array[r_count] = rnd.Next(min_value + 1,max_value + 1);
            }

            int[] max_a = new int[N];
            int[] min_a = new int[N];
            int max = min_value;
            int min = max_value;
            int k = 0;

            for (int i = 1; i < N - 1; i++)
            {
                if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
                {
                    max_a[k] = array[i];
                    k++;
                }
                if ((array[i] < array[i - 1]) && (array[i] < array[i + 1]))
                {
                    min_a[k] = array[i];
                    k++;
                }
            }
            for (int i = 1; i <= k; i++)
            {
                if (min_a[i] > max)
                    max = min_a[i];
                if (max_a[i] < min && max_a[i] != min_value)
                    min = max_a[i];
            }
            Console.WriteLine("Максимальный элемент среди локальных минимумов " + max);
            Console.WriteLine("Минимальный элемент среди локальных максимумов " + min);
        }
    }
}