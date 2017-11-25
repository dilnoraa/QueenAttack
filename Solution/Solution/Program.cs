using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{


    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] tokens_rQueen = Console.ReadLine().Split(' ');
        int rQueen = Convert.ToInt32(tokens_rQueen[0]);
        int cQueen = Convert.ToInt32(tokens_rQueen[1]);
        int[] rDizi = new int[k];
        int[] cDizi = new int[k];
        for (int a0 = 0; a0 < k; a0++)
        {
            string[] tokens_rObstacle = Console.ReadLine().Split(' ');
            rDizi[a0] = Convert.ToInt32(tokens_rObstacle[0]);
            cDizi[a0] = Convert.ToInt32(tokens_rObstacle[1]);
            //  int rObstacle = Convert.ToInt32(tokens_rObstacle[0]);
            // int cObstacle = Convert.ToInt32(tokens_rObstacle[1]);
            // your code goes here
        }

        bool[,] board = new bool[n, n];

        int sayac = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                board[i, j] = true;

        if (n > 1)
        {
            int rowQueen = n - rQueen;
            int columnQueen = cQueen - 1;
            //   board[rowQueen,columnQueen]=1;

            //  Console.WriteLine("int:" + rDizi[0] + cDizi[0]);

            if (k > 0 && k - 1 < n * n)
            {
                for (int i = 0; i < k; i++)
                {
                    int rowO = n - rDizi[i];
                    int columnO = cDizi[i] - 1;
                    board[rowO, columnO] = false;
                }
            }
            /* for(int i=0; i<n; i++) {
             for(int j=0;j<n; j++)
                 Console.Write(board[i,j]+" ");
                 Console.WriteLine();
             }*/

            for (int i = rowQueen - 1; i >= 0; i--)
            { //yukarı

                bool hucre = board[i, columnQueen];
                if (hucre == false)
                    break;

                else
                    sayac++;

            }


            for (int i = rowQueen + 1; i < n; i++)
            { // asagi
                bool hucre = board[i, columnQueen];

                if (hucre == false)
                    break;

                else
                    sayac++;
            }


            for (int i = columnQueen + 1; i < n; i++)
            { // sag
                bool hucre = board[rowQueen, i];

                if (hucre == false)
                    break;

                else
                    sayac++;
            }


            for (int i = columnQueen - 1; i >= 0; i--)
            { // sola
                bool hucre = board[rowQueen, i];

                if (hucre == false)
                    break;

                else
                    sayac++;
            }



            int a = rowQueen;
            int b = columnQueen;
            a--;
            b++;
            while (a >= 0 && b < n)
            { // yukarı-saga
                bool hucre = board[a, b];

                if (hucre == false)
                    break;

                else
                    sayac++;


                a--;
                b++;
            }

            a = rowQueen;
            b = columnQueen;
            a++;
            b++;
            while (a < n && b < n)
            { // asagı-saga
                bool hucre = board[a, b];

                if (hucre == false)
                    break;

                else
                    sayac++;


                a++;
                b++;
            }


            a = rowQueen;
            b = columnQueen;
            a++;
            b--;

            while (a < n && b >= 0)
            { // asagı- sola
                bool hucre = board[a, b];

                if (hucre == false)
                    break;

                else
                    sayac++;


                a++;
                b--;
            }
            a = rowQueen;
            b = columnQueen;
            a--;
            b--;
            while (a >= 0 && b >= 0)
            { // yukari-sola
                bool hucre = board[a, b];
                if (hucre == false)
                    break;

                else
                    sayac++;
                a--;
                b--;
            }
            Console.WriteLine(sayac);
        }
        else
        {
            Console.WriteLine(sayac);

        }
    }
}
