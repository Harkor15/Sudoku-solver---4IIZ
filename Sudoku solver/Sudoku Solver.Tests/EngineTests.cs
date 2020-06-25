using NUnit.Framework;
using System;
using Sudoku_Solver;
using Sudoku_solver;

namespace Sudoku_Solver.Tests
{
 
    public class EngineTests
    {
        [Test]
        public void Test()
        {
            var expected = true;
            var ds = new DataSet();
            var result = Engine.IsDataValid(ds);
            Assert.AreEqual(expected, result);
        }

    }
}
