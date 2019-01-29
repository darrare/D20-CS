using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class SudokuBoard
    {
        int[,] board = new int[9, 9];

        /// <summary>
        /// Defualt constructor for a sudokuboard. Randomly generates solvable boards.
        /// </summary>
        public SudokuBoard()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Overloaded constructor for a sudokuboard that reads in a file and generates
        /// the board based on that files information
        /// </summary>
        /// <param name="fileName">Name of the file you want to load, relative to the binary. \Sudoku\bin\Debug\Sudoku.exe</param>
        /// <param name="lineNum">The line num of the file you want to load (counted as a programmer, first line = 0)</param>
        public SudokuBoard(string fileName, int lineNum)
        {
            string line = "";

            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\" + fileName))
            {
                for (int i = 0; i < lineNum; i++) sr.ReadLine();
                line = sr.ReadLine();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i * 9; j < i * 9 + 9; j++)
                {
                    if (line[j] == '.')
                    {
                        board[i, j % 9] = 0;
                    }
                    else
                    {
                        board[i, j % 9] = int.Parse(line[j].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Prints out the sudoku board in an easily understandable way
        /// </summary>
        public void Print()
        {
            for (int row = 0; row < 9; row++)
            {
                if (row % 3 == 0 && row != 0)
                {
                    Console.WriteLine("---------+---------+---------");
                }
                for(int col = 0; col < 9; col++)
                {
                    if (col % 3 == 0 && col != 0)
                    {
                        Console.Write("|");
                    }
                    Console.Write(" " + board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Checks the entire board to see if it is valid or not.
        /// First, if ANY element in the board is empty (-1) then the board is invalid.
        /// Next, check all rows to make sure every row contains explicitly 1-9, no duplicates.
        /// Next, check all columns to make sure every column contains explicity 1-9, no duplicates.
        /// Next, check all squares to make sure every square contains explicity 1-9, no duplicates.
        /// 
        /// If you are going to return false, because you found an error I recommend printing out the board, as well as
        /// the row/column of the error. Makes it easier to debug.
        /// </summary>
        /// <returns>
        /// True: The board is valid, and solved
        /// False: Something is wrong with the board, whether it has empty elements or is organized incorrectly
        /// </returns>
        public bool Verify()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Your code must look at all the Sudoku board cells in the specified column to find what digits are already used; none of those digits can be used in the blank cell. 
        /// Similarly, the code must look at all the cells in the specified row and reject any digits found. 
        /// And finally, your code must look at all 9 cells in the 3x3 box and reject any digits found.
        /// 
        /// Looking through the 3x3 box is easy once you know where the upper-left corner of the box is, so here is some help.The upper-left corner of the box is at:
        /// int upperRowBox = row - row % 3;
        /// int leftColBox = col - col % 3;
        /// 
        /// Your code must create and return a new list of integers, each integer containing one digit that is not used in the cell’s row, column, or box. 
        /// The list might have zero entries, or nine entries, or anything in between.
        /// 
        /// This method will get executed hundreds or even millions (yes, millions) of times depending on how hard or easy the Sudoku puzzle is. 
        /// If you make a coding mistake in this method, it will be incredibly hard to find (Which of those millions went wrong?).
        /// Therefore you have been provided unit tests that you can use to verify that your FindLegalDigits implementation is correct.
        /// </summary>
        /// <param name="row">Index of the row we want to get results for</param>
        /// <param name="column">Index of the column we want to get the results for</param>
        /// <returns></returns>
        public List<int> FindLegalDigits(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
