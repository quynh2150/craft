using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C5_Example;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CaculatesHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);
            book.AddGrade(100f);

            GradeStatistic stats = book.ComputeStatistic();

            Assert.AreEqual(100f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Name set", book.Name);
            //false
        }

        void SetName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Name set";
        }
    }
}
