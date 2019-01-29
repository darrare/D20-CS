using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FindLegalDigits()
        {
            try
            {
                bool isValid = true;
                if (!isValid)
                {
                    Assert.Fail("isValid was not true");
                }

                int a = 5;
                Assert.AreEqual(a, 5, "Expected value of integer 'a' is 5");
            }
            catch(Exception e)
            {
                Assert.Fail("Exception thrown in testing function.");
            }
        }
    }
}
