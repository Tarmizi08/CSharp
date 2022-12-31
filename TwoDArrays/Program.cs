using System;
using System.Collections;

namespace TwoDArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // declare 2D array
            string[,] matrix;

            //declare 3D aray
            string[,,] matrix2;

            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9} // row 2
            };
            Console.WriteLine("Central value is {0}", array2D[1,1]);
            Console.WriteLine("Central value is {0}", array2D[2, 0]);


            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001" },//inner row 0
                    { "010", "011" },
                    {"Hi there", "Good Morning"}
                },// this entire bracket belong to row 0
                {
                    { "100", "101" },//inner row 0
                    { "110", "111" },
                    {"Good Afternoon", "Good Night"}
                }// this is row 1
            };
            Console.WriteLine("The value id {0}", array3D[1,0,0]);
            Console.WriteLine("The value id {0}", array3D[0,2,1]);

            // specifi the dimension earlier on
            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            array2DString[1, 1] = "chicken";
            Console.WriteLine("Central value is {0}", array2DString[1, 1]);

            // to find the dimension
            int dimension = array2DString.Rank;
            Console.WriteLine("the dimension was {0}", dimension);

            int[,] array2D2 = { { 1, 2 }, { 2, 4 } };
            

            foreach (var item in matrixes)
            {
                Console.WriteLine(item + " ");
                //cannot change the item because it is protected by foreach value storage
            }

            // nested for loop
            Console.WriteLine("This is printing the nested for loops");
            //outer for loop
            for (int i = 0; i < matrixes.GetLength(0); i++)
            {
                // inner loop
                for (int j = 0; j < matrixes.GetLength(1); j++)
                {
                    Console.WriteLine(matrixes[i,j] + " ");
                    // i is row, j is column
                }
            }
            
            // jagged array - array within array
            // declaration
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 1, 5, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 5, 8, 74, 56, 44 }, // first position 0
                new int[] { 3, 5, 4 },
                new int[] { 7, 8, }
            };
            Console.WriteLine("the value is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element at position 0 {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray2[j][i]);
                }
            }
            */

            // declaring an arraylist
            ArrayList myArrayList = new ArrayList(); // undefinite ampunt of an object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            //delete element with specific value entry from arraylist
            myArrayList.Remove(13);

            //delete element at specific index
            myArrayList.RemoveAt(0); // remove 25

            Console.WriteLine((myArrayList.Count));

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);

        }

        //static int[,] matrixes =
        //{
        //    { 1, 2, 3 },
        //    { 4, 5, 6 },
        //    { 7, 8, 9 }
        //};
    }
}

