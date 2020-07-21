using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_solver
{
    /// <summary>
    /// Klasa danych służąca do zbierania informacji o planszy sudoku.
    /// </summary>
    public class DataSet
    {
        public int[,] sudokuData = new int[9,9];
        public bool result;
    }
}
