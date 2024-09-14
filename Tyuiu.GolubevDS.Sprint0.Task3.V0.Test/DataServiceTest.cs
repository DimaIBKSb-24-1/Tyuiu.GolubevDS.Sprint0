using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint0.Task3.V0.Lib;
namespace Tyuiu.GolubevDS.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
