using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public static double Ram(string[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            double z = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    z += Convert.ToDouble(matrix[i, 4]);

                }
            }

            return Math.Round(z / rows);
        }
    }
}
