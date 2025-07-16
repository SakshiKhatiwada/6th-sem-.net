using System;

namespace File3
{
    class Program{
        static void Main(string[] args)
        {
            // code goes here
            // SECTION - Program 1
            // Jagged Array = array with unequal number of columns, unlike a normal array
            int[][] jarray = new int[3][];
            jarray[0] = new int[5] {1,2,3,4,5};
            jarray[1] = new int[3] {6,7,8};
            jarray[2] = new int[] {9,10,11,12,13};

            Console.WriteLine(jarray[0][0]);




        }
    }
}

