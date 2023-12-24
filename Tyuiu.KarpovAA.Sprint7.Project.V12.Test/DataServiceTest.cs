using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint7.Project.V12.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
       
        
        [TestMethod]
        public void ValidAverageValue()
        {
            DataService ds = new DataService();

            double[] arrayNums = { 1, 2, 3 };

            double res = ds.AverageValue(arrayNums);

            double wait = 2;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMinValue()
        {
            DataService ds = new DataService();

            double[] arrayNums = { 1, 2, 3 };

            double res = ds.MinValue(arrayNums);

            double wait = 1;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMaxValue()
        {
            DataService ds = new DataService();

            double[] arrayNums = { 1, 2, 3 };

            double res = ds.MaxValue(arrayNums);

            double wait = 3;

            Assert.AreEqual(wait, res);
        }

    }
}
