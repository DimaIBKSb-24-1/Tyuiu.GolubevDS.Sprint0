using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint0.Task4.V0.Lib;
namespace Tyuiu.GolubevDS.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataSecviceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        public void CheckedMultiplicaton()
        {
            Assert.AreEqual(50, DataService.Multiplicaton(10, 5));
        }
        public void CheckedDivision()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    } 
}
