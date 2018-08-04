using System;

class Solution
{

    // Complete the staircase function below.
    static void staircase(int n)
    {
        string[,] array = new string[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j > n - 2)
                    array[i, j] = "#";
                else array[i, j] = " ";
            }
        }

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                Console.Write(array[j, i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }


    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
