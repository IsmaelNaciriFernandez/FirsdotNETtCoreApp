using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class DataCollections
    {
        //Declare 2D array
        private int[,] _matrix;


        public DataCollections() {

            _matrix = new int[,] {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9}
            };


        }

        public void PrintData()
        {
            //Similar to Java -> for _matrix.length { for _matrix[i].length }
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    Console.Write($" {_matrix[i, j]} |");
                }
            }

            //foreach (var item in _matrix)
            //{
            //    Console.Write(item);
            //}
        }

    }
}
