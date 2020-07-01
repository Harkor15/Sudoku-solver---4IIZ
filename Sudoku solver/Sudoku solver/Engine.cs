using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_solver
{
    public class Engine
    {
       
    public static bool Solve(int[,] fields, int row, int column)
        {
            if (row < 9 && column < 9)
            {
                if (fields[row, column] != 0)
                {
                    if ((column + 1) < 9) return Solve(fields, row, column + 1);
                    else if ((row + 1) < 9) return Solve(fields, row + 1, 0);
                    else return true;
                }
                else
                {
                    for (int i = 0; i < 9; ++i)
                    {
                        if (IsAvailable(fields, row, column, i + 1))
                        {
                            fields[row, column] = i + 1;

                            if ((column + 1) < 9)
                            {
                                if (Solve(fields, row, column + 1)) return true;
                                else fields[row, column] = 0;
                            }
                            else if ((row + 1) < 9)
                            {
                                if (Solve(fields, row + 1, 0)) return true;
                                else fields[row, column] = 0;
                            }
                            else return true;
                        }
                    }
                }

                return false;
            }
            else return true;
        }

        private static bool IsAvailable(int[,] fields, int row, int column, int number)
        {
            int rowStart = (row / 3) * 3;
            int colStart = (column / 3) * 3;

            for (int i = 0; i < 9; ++i)
            {
                if (fields[row, i] == number) return false;
                if (fields[i, column] == number) return false;
                if (fields[rowStart + (i % 3), colStart + (i / 3)] == number) return false;
            }

            return true;
        }

        public static DataSet ComputeResult(DataSet dataSet)
        {
            Solve(dataSet.sudokuData, 0, 0);
            return dataSet;
        }

        public static bool IsDataValid(DataSet dataSet)
        {
            int tmp = 0;

            for (int i = 1; i < 10; i++)
            {
                if (dataSet.sudokuData[0, 0] == i) { tmp++; }
                if (dataSet.sudokuData[0, 1] == i) { tmp++; }
                if (dataSet.sudokuData[0, 2] == i) { tmp++; }
                if (dataSet.sudokuData[0, 3] == i) { tmp++; }
                if (dataSet.sudokuData[0, 4] == i) { tmp++; }
                if (dataSet.sudokuData[0, 5] == i) { tmp++; }
                if (dataSet.sudokuData[0, 6] == i) { tmp++; }
                if (dataSet.sudokuData[0, 7] == i) { tmp++; }
                if (dataSet.sudokuData[0, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[1, 0] == i) { tmp++; }
                if (dataSet.sudokuData[1, 1] == i) { tmp++; }
                if (dataSet.sudokuData[1, 2] == i) { tmp++; }
                if (dataSet.sudokuData[1, 3] == i) { tmp++; }
                if (dataSet.sudokuData[1, 4] == i) { tmp++; }
                if (dataSet.sudokuData[1, 5] == i) { tmp++; }
                if (dataSet.sudokuData[1, 6] == i) { tmp++; }
                if (dataSet.sudokuData[1, 7] == i) { tmp++; }
                if (dataSet.sudokuData[1, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[2, 0] == i) { tmp++; }
                if (dataSet.sudokuData[2, 1] == i) { tmp++; }
                if (dataSet.sudokuData[2, 2] == i) { tmp++; }
                if (dataSet.sudokuData[2, 3] == i) { tmp++; }
                if (dataSet.sudokuData[2, 4] == i) { tmp++; }
                if (dataSet.sudokuData[2, 5] == i) { tmp++; }
                if (dataSet.sudokuData[2, 6] == i) { tmp++; }
                if (dataSet.sudokuData[2, 7] == i) { tmp++; }
                if (dataSet.sudokuData[2, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[3, 0] == i) { tmp++; }
                if (dataSet.sudokuData[3, 1] == i) { tmp++; }
                if (dataSet.sudokuData[3, 2] == i) { tmp++; }
                if (dataSet.sudokuData[3, 3] == i) { tmp++; }
                if (dataSet.sudokuData[3, 4] == i) { tmp++; }
                if (dataSet.sudokuData[3, 5] == i) { tmp++; }
                if (dataSet.sudokuData[3, 6] == i) { tmp++; }
                if (dataSet.sudokuData[3, 7] == i) { tmp++; }
                if (dataSet.sudokuData[3, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[4, 0] == i) { tmp++; }
                if (dataSet.sudokuData[4, 1] == i) { tmp++; }
                if (dataSet.sudokuData[4, 2] == i) { tmp++; }
                if (dataSet.sudokuData[4, 3] == i) { tmp++; }
                if (dataSet.sudokuData[4, 4] == i) { tmp++; }
                if (dataSet.sudokuData[4, 5] == i) { tmp++; }
                if (dataSet.sudokuData[4, 6] == i) { tmp++; }
                if (dataSet.sudokuData[4, 7] == i) { tmp++; }
                if (dataSet.sudokuData[4, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[5, 0] == i) { tmp++; }
                if (dataSet.sudokuData[5, 1] == i) { tmp++; }
                if (dataSet.sudokuData[5, 2] == i) { tmp++; }
                if (dataSet.sudokuData[5, 3] == i) { tmp++; }
                if (dataSet.sudokuData[5, 4] == i) { tmp++; }
                if (dataSet.sudokuData[5, 5] == i) { tmp++; }
                if (dataSet.sudokuData[5, 6] == i) { tmp++; }
                if (dataSet.sudokuData[5, 7] == i) { tmp++; }
                if (dataSet.sudokuData[5, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[6, 0] == i) { tmp++; }
                if (dataSet.sudokuData[6, 1] == i) { tmp++; }
                if (dataSet.sudokuData[6, 2] == i) { tmp++; }
                if (dataSet.sudokuData[6, 3] == i) { tmp++; }
                if (dataSet.sudokuData[6, 4] == i) { tmp++; }
                if (dataSet.sudokuData[6, 5] == i) { tmp++; }
                if (dataSet.sudokuData[6, 6] == i) { tmp++; }
                if (dataSet.sudokuData[6, 7] == i) { tmp++; }
                if (dataSet.sudokuData[6, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[7, 0] == i) { tmp++; }
                if (dataSet.sudokuData[7, 1] == i) { tmp++; }
                if (dataSet.sudokuData[7, 2] == i) { tmp++; }
                if (dataSet.sudokuData[7, 3] == i) { tmp++; }
                if (dataSet.sudokuData[7, 4] == i) { tmp++; }
                if (dataSet.sudokuData[7, 5] == i) { tmp++; }
                if (dataSet.sudokuData[7, 6] == i) { tmp++; }
                if (dataSet.sudokuData[7, 7] == i) { tmp++; }
                if (dataSet.sudokuData[7, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[8, 0] == i) { tmp++; }
                if (dataSet.sudokuData[8, 1] == i) { tmp++; }
                if (dataSet.sudokuData[8, 2] == i) { tmp++; }
                if (dataSet.sudokuData[8, 3] == i) { tmp++; }
                if (dataSet.sudokuData[8, 4] == i) { tmp++; }
                if (dataSet.sudokuData[8, 5] == i) { tmp++; }
                if (dataSet.sudokuData[8, 6] == i) { tmp++; }
                if (dataSet.sudokuData[8, 7] == i) { tmp++; }
                if (dataSet.sudokuData[8, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 0] == i) { tmp++; }
                if (dataSet.sudokuData[1, 0] == i) { tmp++; }
                if (dataSet.sudokuData[2, 0] == i) { tmp++; }
                if (dataSet.sudokuData[3, 0] == i) { tmp++; }
                if (dataSet.sudokuData[4, 0] == i) { tmp++; }
                if (dataSet.sudokuData[5, 0] == i) { tmp++; }
                if (dataSet.sudokuData[6, 0] == i) { tmp++; }
                if (dataSet.sudokuData[7, 0] == i) { tmp++; }
                if (dataSet.sudokuData[8, 0] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 1] == i) { tmp++; }
                if (dataSet.sudokuData[1, 1] == i) { tmp++; }
                if (dataSet.sudokuData[2, 1] == i) { tmp++; }
                if (dataSet.sudokuData[3, 1] == i) { tmp++; }
                if (dataSet.sudokuData[4, 1] == i) { tmp++; }
                if (dataSet.sudokuData[5, 1] == i) { tmp++; }
                if (dataSet.sudokuData[6, 1] == i) { tmp++; }
                if (dataSet.sudokuData[7, 1] == i) { tmp++; }
                if (dataSet.sudokuData[8, 1] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 2] == i) { tmp++; }
                if (dataSet.sudokuData[1, 2] == i) { tmp++; }
                if (dataSet.sudokuData[2, 2] == i) { tmp++; }
                if (dataSet.sudokuData[3, 2] == i) { tmp++; }
                if (dataSet.sudokuData[4, 2] == i) { tmp++; }
                if (dataSet.sudokuData[5, 2] == i) { tmp++; }
                if (dataSet.sudokuData[6, 2] == i) { tmp++; }
                if (dataSet.sudokuData[7, 2] == i) { tmp++; }
                if (dataSet.sudokuData[8, 2] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 3] == i) { tmp++; }
                if (dataSet.sudokuData[1, 3] == i) { tmp++; }
                if (dataSet.sudokuData[2, 3] == i) { tmp++; }
                if (dataSet.sudokuData[3, 3] == i) { tmp++; }
                if (dataSet.sudokuData[4, 3] == i) { tmp++; }
                if (dataSet.sudokuData[5, 3] == i) { tmp++; }
                if (dataSet.sudokuData[6, 3] == i) { tmp++; }
                if (dataSet.sudokuData[7, 3] == i) { tmp++; }
                if (dataSet.sudokuData[8, 3] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 4] == i) { tmp++; }
                if (dataSet.sudokuData[1, 4] == i) { tmp++; }
                if (dataSet.sudokuData[2, 4] == i) { tmp++; }
                if (dataSet.sudokuData[3, 4] == i) { tmp++; }
                if (dataSet.sudokuData[4, 4] == i) { tmp++; }
                if (dataSet.sudokuData[5, 4] == i) { tmp++; }
                if (dataSet.sudokuData[6, 4] == i) { tmp++; }
                if (dataSet.sudokuData[7, 4] == i) { tmp++; }
                if (dataSet.sudokuData[8, 4] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 5] == i) { tmp++; }
                if (dataSet.sudokuData[1, 5] == i) { tmp++; }
                if (dataSet.sudokuData[2, 5] == i) { tmp++; }
                if (dataSet.sudokuData[3, 5] == i) { tmp++; }
                if (dataSet.sudokuData[4, 5] == i) { tmp++; }
                if (dataSet.sudokuData[5, 5] == i) { tmp++; }
                if (dataSet.sudokuData[6, 5] == i) { tmp++; }
                if (dataSet.sudokuData[7, 5] == i) { tmp++; }
                if (dataSet.sudokuData[8, 5] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 6] == i) { tmp++; }
                if (dataSet.sudokuData[1, 6] == i) { tmp++; }
                if (dataSet.sudokuData[2, 6] == i) { tmp++; }
                if (dataSet.sudokuData[3, 6] == i) { tmp++; }
                if (dataSet.sudokuData[4, 6] == i) { tmp++; }
                if (dataSet.sudokuData[5, 6] == i) { tmp++; }
                if (dataSet.sudokuData[6, 6] == i) { tmp++; }
                if (dataSet.sudokuData[7, 6] == i) { tmp++; }
                if (dataSet.sudokuData[8, 6] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 7] == i) { tmp++; }
                if (dataSet.sudokuData[1, 7] == i) { tmp++; }
                if (dataSet.sudokuData[2, 7] == i) { tmp++; }
                if (dataSet.sudokuData[3, 7] == i) { tmp++; }
                if (dataSet.sudokuData[4, 7] == i) { tmp++; }
                if (dataSet.sudokuData[5, 7] == i) { tmp++; }
                if (dataSet.sudokuData[6, 7] == i) { tmp++; }
                if (dataSet.sudokuData[7, 7] == i) { tmp++; }
                if (dataSet.sudokuData[8, 7] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 8] == i) { tmp++; }
                if (dataSet.sudokuData[1, 8] == i) { tmp++; }
                if (dataSet.sudokuData[2, 8] == i) { tmp++; }
                if (dataSet.sudokuData[3, 8] == i) { tmp++; }
                if (dataSet.sudokuData[4, 8] == i) { tmp++; }
                if (dataSet.sudokuData[5, 8] == i) { tmp++; }
                if (dataSet.sudokuData[6, 8] == i) { tmp++; }
                if (dataSet.sudokuData[7, 8] == i) { tmp++; }
                if (dataSet.sudokuData[8, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 0] == i) { tmp++; }
                if (dataSet.sudokuData[0, 1] == i) { tmp++; }
                if (dataSet.sudokuData[0, 2] == i) { tmp++; }
                if (dataSet.sudokuData[1, 0] == i) { tmp++; }
                if (dataSet.sudokuData[1, 1] == i) { tmp++; }
                if (dataSet.sudokuData[1, 2] == i) { tmp++; }
                if (dataSet.sudokuData[2, 0] == i) { tmp++; }
                if (dataSet.sudokuData[2, 1] == i) { tmp++; }
                if (dataSet.sudokuData[2, 2] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 3] == i) { tmp++; }
                if (dataSet.sudokuData[0, 4] == i) { tmp++; }
                if (dataSet.sudokuData[0, 5] == i) { tmp++; }
                if (dataSet.sudokuData[1, 3] == i) { tmp++; }
                if (dataSet.sudokuData[1, 4] == i) { tmp++; }
                if (dataSet.sudokuData[1, 5] == i) { tmp++; }
                if (dataSet.sudokuData[2, 3] == i) { tmp++; }
                if (dataSet.sudokuData[2, 4] == i) { tmp++; }
                if (dataSet.sudokuData[2, 5] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[0, 6] == i) { tmp++; }
                if (dataSet.sudokuData[0, 7] == i) { tmp++; }
                if (dataSet.sudokuData[0, 8] == i) { tmp++; }
                if (dataSet.sudokuData[1, 6] == i) { tmp++; }
                if (dataSet.sudokuData[1, 7] == i) { tmp++; }
                if (dataSet.sudokuData[1, 8] == i) { tmp++; }
                if (dataSet.sudokuData[2, 6] == i) { tmp++; }
                if (dataSet.sudokuData[2, 7] == i) { tmp++; }
                if (dataSet.sudokuData[2, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[3, 0] == i) { tmp++; }
                if (dataSet.sudokuData[3, 1] == i) { tmp++; }
                if (dataSet.sudokuData[3, 2] == i) { tmp++; }
                if (dataSet.sudokuData[4, 0] == i) { tmp++; }
                if (dataSet.sudokuData[4, 1] == i) { tmp++; }
                if (dataSet.sudokuData[4, 2] == i) { tmp++; }
                if (dataSet.sudokuData[5, 0] == i) { tmp++; }
                if (dataSet.sudokuData[5, 1] == i) { tmp++; }
                if (dataSet.sudokuData[5, 2] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[3, 3] == i) { tmp++; }
                if (dataSet.sudokuData[3, 4] == i) { tmp++; }
                if (dataSet.sudokuData[3, 5] == i) { tmp++; }
                if (dataSet.sudokuData[4, 3] == i) { tmp++; }
                if (dataSet.sudokuData[4, 4] == i) { tmp++; }
                if (dataSet.sudokuData[4, 5] == i) { tmp++; }
                if (dataSet.sudokuData[5, 3] == i) { tmp++; }
                if (dataSet.sudokuData[5, 4] == i) { tmp++; }
                if (dataSet.sudokuData[5, 5] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[3, 6] == i) { tmp++; }
                if (dataSet.sudokuData[3, 7] == i) { tmp++; }
                if (dataSet.sudokuData[3, 8] == i) { tmp++; }
                if (dataSet.sudokuData[4, 6] == i) { tmp++; }
                if (dataSet.sudokuData[4, 7] == i) { tmp++; }
                if (dataSet.sudokuData[4, 8] == i) { tmp++; }
                if (dataSet.sudokuData[5, 6] == i) { tmp++; }
                if (dataSet.sudokuData[5, 7] == i) { tmp++; }
                if (dataSet.sudokuData[5, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[6, 0] == i) { tmp++; }
                if (dataSet.sudokuData[6, 1] == i) { tmp++; }
                if (dataSet.sudokuData[6, 2] == i) { tmp++; }
                if (dataSet.sudokuData[7, 0] == i) { tmp++; }
                if (dataSet.sudokuData[7, 1] == i) { tmp++; }
                if (dataSet.sudokuData[7, 2] == i) { tmp++; }
                if (dataSet.sudokuData[8, 0] == i) { tmp++; }
                if (dataSet.sudokuData[8, 1] == i) { tmp++; }
                if (dataSet.sudokuData[8, 2] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[6, 3] == i) { tmp++; }
                if (dataSet.sudokuData[6, 4] == i) { tmp++; }
                if (dataSet.sudokuData[6, 5] == i) { tmp++; }
                if (dataSet.sudokuData[7, 3] == i) { tmp++; }
                if (dataSet.sudokuData[7, 4] == i) { tmp++; }
                if (dataSet.sudokuData[7, 5] == i) { tmp++; }
                if (dataSet.sudokuData[8, 3] == i) { tmp++; }
                if (dataSet.sudokuData[8, 4] == i) { tmp++; }
                if (dataSet.sudokuData[8, 5] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
                if (dataSet.sudokuData[6, 6] == i) { tmp++; }
                if (dataSet.sudokuData[6, 7] == i) { tmp++; }
                if (dataSet.sudokuData[6, 8] == i) { tmp++; }
                if (dataSet.sudokuData[7, 6] == i) { tmp++; }
                if (dataSet.sudokuData[7, 7] == i) { tmp++; }
                if (dataSet.sudokuData[7, 8] == i) { tmp++; }
                if (dataSet.sudokuData[8, 6] == i) { tmp++; }
                if (dataSet.sudokuData[8, 7] == i) { tmp++; }
                if (dataSet.sudokuData[8, 8] == i) { tmp++; }
                if (tmp > 1) { return false; }
                tmp = 0;
            }
            return true;
        }
    }
}
