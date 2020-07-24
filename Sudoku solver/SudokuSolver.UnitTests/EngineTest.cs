using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku_solver;

namespace SudokuSolver.UnitTests
{
    /// <summary>
    /// Klasa zawierająca testy klasy Engine
    /// </summary>
    [TestClass]
    public class EngineTests
    {
        /// <summary>
        /// Test poprawności działania matody sprawdzającej poprawność danych dla poprawnych danych
        /// </summary>
        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataSet();
            int[,] sudoku ={
                { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                { 0, 0, 0, 6, 0, 9, 5, 8, 2 }
                };
            ds.sudokuData = sudoku;
            var result = Engine.IsDataValid(ds);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test poprawności działania matody sprawdzającej poprawność danych dla błędnych danych
        /// </summary>
        [TestMethod]
        public void ValidTest2()
        {
            var ds = new DataSet();
            int[,] sudoku ={
                { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                { 0, 0, 0, 7, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                { 0, 0, 0, 6, 0, 9, 5, 8, 2 }
                };
            ds.sudokuData = sudoku;
            var result = Engine.IsDataValid(ds);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test poprawności działania matody sprawdzającej poprawność danych dla błędnych danych
        /// </summary>
        [TestMethod]
        public void ValidTest3()
        {
            var ds = new DataSet();
            int[,] sudoku ={
                { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                { 0, 0, 0, 6, 0, 9, 5, 8, 1 }
                };
            ds.sudokuData = sudoku;
            var result = Engine.IsDataValid(ds);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void SolvingTest()
        {
            var ds = new DataSet();
            int[,] sudoku ={
                { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                { 0, 0, 0, 6, 0, 9, 5, 8, 2 }
                };
            ds.sudokuData = sudoku;
            var result=Engine.ComputeResult(ds);
           
            int[,] expected ={
                { 3,2,1,7,5,4,6,9,8 },
                { 6,4,8,2,9,3,1,5,7 },
                { 5,7,9,8,1,6,2,3,4 },
                { 7,8,2,3,4,5,9,6,1 },
                { 9,6,5,1,8,7,4,2,3 },
                { 1,3,4,9,6,2,8,7,5 },
                { 8,9,3,5,2,1,7,4,6 },
                { 2,5,6,4,7,8,3,1,9 },
                { 4,1,7,6,3,9,5,8,2 }
                };

            for(int i=0; i < 9; i++)
            {
                for( int j = 0; j < 9; j++)
                {
                    Assert.AreEqual(expected[i, j], result.sudokuData[i, j]);

                }
            }

               
            
        }

    }
}
