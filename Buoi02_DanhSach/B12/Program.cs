using System;
class Program
{
    static void Main()
    {
        int m = 5, n = 5, soMin = 5;
        int[,] board = new int[m, n];
        Random rand = new Random();

        int daDat = 0;
        while (daDat < soMin)
        {
            int r = rand.Next(0, m);
            int c = rand.Next(0, n);
            if (board[r, c] != -1)
            {
                board[r, c] = -1;
                daDat++;
            }
        }
        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i, j] == -1) continue;

                int count = 0;
                for (int k = 0; k < 8; k++)
                {
                    int ni = i + dx[k];
                    int nj = j + dy[k];
                    if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == -1)
                    {
                        count++;
                    }
                }
                board[i, j] = count;
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write((board[i, j] == -1 ? "*" : board[i, j].ToString()) + " ");
            }
            Console.WriteLine();
        }
    }
}