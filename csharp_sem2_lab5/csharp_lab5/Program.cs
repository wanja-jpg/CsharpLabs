using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M;
            do
            {
                Console.WriteLine("M=");
                M = int.Parse(Console.ReadLine());
                if(M <= 0)
                {
                    Console.WriteLine("Неверное значение M");
                }
            } while (M <= 0);

            int[,] array = new int[M,M];

            Random rnd = new Random();
            const int max_value = 10;
            for (int r_count = 0; r_count < M; r_count++)
            {
                for(int c_count = 0;c_count < M; c_count++)
                {
                    array[r_count,c_count] = rnd.Next(max_value+1);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int[] sum = new int[((M * 2) - 1)*2];
            int k = 0;

            // с левого нижнего края до главной диагонали
            for (int i = 0; i < M; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    sum[k] += array[M - i - 1 + j,j];
                }
                k++;
            }

            // после главной диагонали
            for (int i = 0; i < M - 1; i++)
            {
                for (int j = M - 1; j >= i + 1; j--)
                {
                    sum[k] += array[j - i - 1,j];
                }
                k++;
            }

            // с правого нижнего края до побочной диагонали
            for (int i = M-1,j= M-1; j > -1;j--)
            {
                i = M - 1;
                for (int i_count=0,j_count=0;j+j_count < M ;j_count++,i_count++)
                {
                    sum[k] += array[i-i_count, j+j_count];
                }
                k++;
            }

            // после побочной диагонали
            for (int i = M-2,j = 0; i > -1; i--)
            {
                j = 0;
                for (int i_count = 0, j_count = 0; i - i_count > -1; j_count++, i_count++)
                {
                    sum[k] += array[i - i_count, j + j_count];
                }
                k++;
            }

            Console.WriteLine("Сума всех диагоналей");
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + "\t");
            }
        }
    }
}
