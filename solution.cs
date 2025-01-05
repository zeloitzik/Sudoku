using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Solution
    {
        private HashSet<char>[] rowVal;
        private HashSet<char>[] colVal;
        private HashSet<char>[] boxVal;
        public Solution()
        {
            
        }
        public void InitialSetUp(char[,] board)
        {
            rowVal = new HashSet<char>[9];
            colVal = new HashSet<char>[9];
            boxVal = new HashSet<char>[9];
            for (int i = 0; i < 9; i++)
            {
                rowVal[i] = new HashSet<char>();
                colVal[i] = new HashSet<char>();
                boxVal[i] = new HashSet<char>();
            }
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    char cell = board[row, col];
                    if (cell == '.') continue;
                    int boxIndex = (row / 3) * 3 + (col / 3);
                    rowVal[row].Add(cell);
                    colVal[col].Add(cell);
                    boxVal[boxIndex].Add(cell);
                }
            }

            SolveSudoku(board, 0, 0);

        }

        public bool SolveSudoku(char[,] board, int row, int col)
        {
            if (row >= 9 || row == 8 && col > 8) return true;
            char cell = board[row, col];
            while (cell != '.')
            {
                col++;
                if (col == 9)
                {
                    col = 0;
                    row++;
                }
                if (row >= 9 || row == 8 && col > 8) return true;
                cell = board[row, col];
            }
            int boxIndex = (row / 3) * 3 + (col / 3);
            bool isValid = false;
            for (int i = 1; i <= 9; i++)
            {
                char cInum = Convert.ToChar(48 + i);
                if (rowVal[row].Contains(cInum) ||
                    colVal[col].Contains(cInum) || 
                    boxVal[boxIndex].Contains(cInum)) continue;

                board[row,col] = cInum;
                rowVal[row].Add(cInum);
                colVal[col].Add(cInum);
                boxVal[boxIndex].Add(cInum);
                for (int t = 0; t < board.GetLength(0); t++)
                {
                    for (int h = 0; h < board.GetLength(1); h++)
                        Console.Write(board[t, h] + "  ");
                    Console.WriteLine();
                }
                Console.WriteLine("Changed Board - \n\n");
                isValid = SolveSudoku(board,row,col);
                if(isValid) { return isValid; }
                else
                {
                    board[row, col] = '.';
                    rowVal[row].Remove(cInum);
                    colVal[col].Remove(cInum);
                    boxVal[boxIndex].Remove(cInum);
                }
            }
            return isValid;

        }
    }
        
    }


