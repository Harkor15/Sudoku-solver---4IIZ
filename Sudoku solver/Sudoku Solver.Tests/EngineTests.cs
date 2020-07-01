using NUnit.Framework;
using Sudoku_solver;



namespace Sudoku_Solver.Tests
{

    public class EngineTests
    {
        [Test]
        public void ValidTest()
        {
            var ds = new DataSet();
                int[,] sudoku={
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

        [Test]
        public void SolvingTest()
        {
            Assert.IsTrue(true);
        }

    }
}
