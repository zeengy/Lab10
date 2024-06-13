using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 3; 
            int[][] matrix = new int[N][];
            matrix[0] = new int[] { 8, 2, 5 };
            matrix[1] = new int[] { 1, 1, 6 };
            matrix[2] = new int[] { 9, 8, 7 };

            int[] diagonal = new int[N];

            for (int i = 0; i < N; i++)
            {
                diagonal[i] = matrix[i][i];
            }

            Array.Sort(diagonal);

            Console.WriteLine("Відсортована головна діагональ:");
            foreach (int num in diagonal)
            {
                Console.Write(num + " ");
            }
        }
    }
}
