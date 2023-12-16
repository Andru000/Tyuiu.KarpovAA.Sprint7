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
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\OutPutFile.csv";

            FileInfo fileinfo = new FileInfo(path);

            bool fileex = fileinfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileex);
        }
    }
}
