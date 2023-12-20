using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint7.Project.V12.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        
        DataService ds = new DataService();


        [TestMethod]
        public void Check()
        {
            string path = @"C:\Users\karpo\source\repos\Tyuiu.KarpovAA.Sprint7\Tyuiu.KarpovAA.Sprint7.Project.V12\bin\Debug\OutPutIVM.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);

        }

        string filePath = @"C:\Users\karpo\source\repos\Tyuiu.KarpovAA.Sprint7\Tyuiu.KarpovAA.Sprint7.Project.V12\bin\Debug\OutPutIVM.csv";

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }

        [TestMethod]
        public void CheckOZU()
        {
            double wait = 11.33;
            double res = ds.RAM(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckMAX()
        {
            double wait = 11;
            double res = ds.MaxCore(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
    }
}
