using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class DataCollections
    {
        //Declare jagged array (declare an array that has arrays inside)
        private int[][] _jaggedArray;


        public DataCollections() {

            _jaggedArray = new int[3][];
            _jaggedArray[0] = new int[3] { 5, 7, 8 };
            _jaggedArray[1] = new int[9] { 5, 65, 7687, 987,321,435,4, 12, 4};
            _jaggedArray[2] = new int[5] {12, 65, 231, 87, 03};

        }

        public void PrintData()
        {

            Console.WriteLine($"Printing middle value of 2nd position {_jaggedArray[1][4]}");
        }
    }
}
