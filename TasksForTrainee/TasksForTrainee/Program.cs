using System;

namespace TasksForTrainee
{
    class Program
    {
        static void Main(string[] args)
        {

             bool checkWorkAlgoritm = false;
            
           // two arrays for check algoritm
         int[,] Array9x9 = new int[9, 9]
         {
                {7,8,4, 1,5,9, 3,2,6 },
                {5,3,9, 6,7,2, 8,4,1},
                {6,1,2, 4,3,8, 7,5,9},

                {9,2,8, 7,1,5, 4,6,3},
                {3,5,7, 8,4,6, 1,9,2},
                {4,6,1, 9,2,3, 5,8,7},

                {8,7,6, 3,9,4, 2,1,5},
                {2,4,3, 5,6,1, 9,7,8},
                {1,9,5, 2,8,7, 6,3,4}
         };

         int[,] Array4x4 = new int[4, 4]
          {
                {7,8,    4,1},
                {5,3,    9,6},

                {6,1,    2,4},
                {9,2,    8,7},

          };

            Console.WriteLine("Enter  N:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 9) { checkWorkAlgoritm = Sudoku.AlgoritmSudoku(n, Array9x9); Console.WriteLine( "Field 9x9: " + checkWorkAlgoritm); }
            else if (n == 4 ) { checkWorkAlgoritm = Sudoku.AlgoritmSudoku(n, Array4x4); Console.WriteLine("Field 4x4: " + checkWorkAlgoritm); }
           

        }
    }
}
