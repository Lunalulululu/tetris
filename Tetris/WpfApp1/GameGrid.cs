using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;

        private int rows;
        public int Rows
        {
            get => rows;
            set => rows = value;
        }

        private int columns;
        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }
        /*
         * public int Rows { get; }
         * public int Columns { get; }
         */
        public int this[int r, int c]
        {
            // get => grid[r, c];
            get { return grid[r, c]; }

            // set => grid[r, c] = value;
            set { grid[r, c] = value; }

        }
        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }
        /* keep a variable cleared to keep track of how many rows it has cleared
           if clear > 0, the current row will be moved one row below it
           grid[r+clear,c] = grid[r, c]
           if the row is full, clear++, remove the row
           if the row is not full
             clear > 0
             grid[r+clear,c] = grid[r, c]
        */
        public int ClearFullRows()
        {
            int cleared = 0;
            // start filling bottom row
            for (int r = Rows - 1; r >= 0; r--)
            {
                if (IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if (cleared > 0)
                {
                    MoveRowDown(r, cleared);
                }
            }
            return cleared;
        }

        private void MoveRowDown(int r, int cleared)
        {
            for (int c = 0; c <= Columns - 1; c++)
            {
                grid[r + cleared, c] = grid[r, c];
                grid[r, c] = 0;
            }
        }
        private void ClearRow(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                grid[r, c] = 0;
            }
        }

        public bool IsRowFull(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsInside(int r, int c)
        {
            return r >= 0 && r < Rows && c >= 0 && c < Columns;
        }
        public bool IsEmpty(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == 0;
        }
    }
}
