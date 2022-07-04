using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForTrainee
{
    class Sudoku
    {
    
      public static  bool AlgoritmSudoku(int n, int[,] field)
        {

            double NSqrt = Math.Sqrt(n);
            int[] array_part = new int[n];

            if (n > 1 && n % NSqrt == 0 && field.GetLength(0) == n && field.GetLength(1) == n)
            {

                // 1 - check all rows horizontal
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        array_part[j] = field[i,j];
                    }
                    if (!CheckOnePart(array_part)) { Console.WriteLine("1 step"); return false; };
                }


                // 2 - check all rows vertical

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)   
                    {
                        array_part[j] = field[j, i];
                    }
                    if (!CheckOnePart(array_part)) { Console.WriteLine("2 step"); return false; };
                }


                // 3 - check  all parts , example 3x3, 2x2... 
                for (int i = 0; i < n; i += Convert.ToInt32(NSqrt))
                {
                    for (int j = 0; j < n; j += Convert.ToInt32(NSqrt))
                    {
                        int index = 0;
                        for (int s = 0; s < Math.Sqrt(n); s++)
                        {
                            for (int q = 0; q < Math.Sqrt(n); q++)
                            {
                                array_part[index] = field[i + s, j + q]; index++;
                            }
                        }
                        if (!CheckOnePart(array_part)) { Console.WriteLine("3 step"); return false; };
                    }

                }

                return true;
            }
            else return false;

           
        }


       public static bool CheckOnePart(int[] array_part)
        {
            for(int i = 0; i < array_part.Length; i++)
            {
                for (int j = 0; j < array_part.Length; j++)
                {
                    if(array_part[i] == array_part[j] && i!=j) { return false; }
                }

            }

            return true;
        }

    }

}
