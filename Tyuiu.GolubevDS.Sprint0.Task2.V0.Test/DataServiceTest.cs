﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GolubevDS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дима";
            var res = DataService.GetMessage(name);
            Assert.AreNotEqual("Привет, Дима", res);
        }
    }
}
