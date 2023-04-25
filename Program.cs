using System;
using static System.Console;
using System.IO;
using static System.Array;

namespace Array_Excercise3
{
    public class Bai3
    {
        public static void Main() 
        {
            //Bai3 d2 = new Bai3();
            //d2.JaggedArray();
            
            Bai3 d1 = new Bai3();
            //d1.MaTran();
            d1.JaggedArray();

        }
        public void JaggedArray()
        {
            int i, j;
            int[][] arr1 = new int[10][];

           
            Write("Kich co ma tran vuong: ");
            int n = Convert.ToInt32(ReadLine());

            /* nhap cac phan tu vao trong mang*/
            WriteLine();
            Write("Nhap cac phan tu vao trong ma tran:\n");
            for (i = 0; i < n; i++)
            {
                arr1[i] = new int[n];
                for (j = 0; j < n; j++)
                {
                    Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i][j] = Convert.ToInt32(ReadLine());
                    
                    if (arr1[i][j] == 0)
                    {
                        WriteLine("LOI");
                        return;
                    }
                }
            }

            Write("\nIn ma tran: \n");
            for (i = 0; i < n; i++)
            {
                Write("\n");
                for (j = 0; j < n; j++)
                    Write("{0}\t", arr1[i][j]);
            }
            Write("\n\n");

            ReadKey();
        }
        public void MaTran()
        {
            int i, j;
            int[,] arr1 = new int[10,10];
            int sum = 0;
            int m = 0;

            Write("Ma tran vuong NxN");
            /* nhap cac phan tu vao trong mang*/
            WriteLine();
            Write("Nhap vao so hang va cot vuong: ");
            int n = Convert.ToInt32(ReadLine());
            m = n;
            Write("Nhap cac phan tu vao trong ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(ReadLine());
                    if (i == j) sum = sum + arr1[i, j];             //Tong duong cheo chinh
                }
            }
            Clear();

            Write("\nIn ma tran: \n");
            for (i = 0; i < n; i++)
            {
                Write("\n");
                for (j = 0; j < n; j++)
                    Write("{0}\t", arr1[i, j]);
            }
            Write("\n\n");
            Write("Tong cac phan tu tren duong cheo chinh la: {0}\n", sum);

            sum = 0;
            // tinh tong cac phan tu tren duong cheo phu 
            for (i = 0; i < n; i++)
            {
                
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }

                }
            }
            Console.Write("Tong cac phan tu tren duong cheo phu la: {0}\n", sum);

            ReadKey();
        }
    }
}
