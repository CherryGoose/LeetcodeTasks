using System;

namespace Word_search
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[3][];
            board[0] = new char[3] { 'C', 'A', 'A'};
            board[1] = new char[3] { 'A', 'A', 'A'};
            board[2] = new char[3] { 'B', 'C', 'D' };
            string word = "AAB";

            char[][] used = new char[board.Length][];
            for(int i=0;i<board.Length;i++)
            {
                used[i] = new char[board[0].Length];
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    used[i][j] = 'U';
                }
            }
            bool end = false;
            int position = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {

                    if (word[position] == board[i][j])
                    {
                        CheckNrs(board, i, j, word, position, used, ref end);
                    }
                }
            }

            Console.WriteLine(false);

        }

        public static void CheckNrs(char[][] bd, int i, int j,string word, int position, char[][] ar, ref bool  end)
        {

            for (int k = 0; k < ar.Length; k++)
            {
                for (int m = 0; m < ar[0].Length; m++)
                {
                     Console.Write(ar[k][m]+" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("____________");

            if (position == word.Length-1)
            { end= true;
                }
            if (ar[i][ j] == 'U' && word[position] == bd[i][j])
            {
                try
                {
                    if (bd[i + 1][j] == word[position + 1] && ar[i + 1][ j] == 'U')
                    {
                        ar[i][ j] = 'N';
                        CheckNrs(bd, i + 1, j, word, position + 1, ar, ref end);
                        return;
                    }
                } catch { Exception x; }

                try
                {
                    if (bd[i][j + 1] == word[position + 1] && ar[i][ j+1] == 'U')
                {
                        ar[i][j] = 'N';
                        CheckNrs(bd, i, j+1, word, position + 1, ar, ref end);
                        return;

                    }
                }
                catch { Exception x; }

                try
                {
                    if (bd[i - 1][j] == word[position + 1] && ar[i - 1][ j] == 'U')
                {
                        ar[i][j] = 'N';
                        CheckNrs(bd, i-1, j, word, position + 1, ar, ref end);
                        return;

                    }
                } catch { Exception x; }

                try
                {
                    if (bd[i][j - 1] == word[position + 1] && ar[i ][ j-1] == 'U')
                {
                        ar[i][j] = 'N';
                        CheckNrs(bd, i, j-1, word, position + 1, ar, ref end);
                        return;

                    }
                } catch { Exception x;    }                 
                
                if(position != word.Length)
                    position = 0;
                    for (int k = 0; k < ar.Length; k++)
                    {
                        for (int m = 0; m < ar[0].Length; m++)
                        {
                            ar[k][m] = 'U';
                        }
                    }
            }
        }
    }
}
