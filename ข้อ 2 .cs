using System;
using System.Collections.Generic;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int number,tmp;

            Console.Write("Input the size of array : ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array !!! ", number);
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < number; i++)
            {
                Console.Write("Numberic - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();


            ///////////////////// แบบที่ 1
            for (int i = 0; i < number; i++)
            {
                for (int j = i + 1; j < number; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Banking’s Sort ... ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");



            ///////////////////// แบบที่ 2
            for (int i = 0; i < number; i++)
            {
                for (int j = i + 1; j < number; j++) 
                {
                    if (arr1[i] > arr1[j]) ///// ------> ต่างกับแบบที่ 1 ตรงนี้
                    {
                        tmp =  arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Phun’s Sort ... ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");


            ///////////////////// แบบที่ 3
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number - 1; j++)
                {
                    if (arr1[j] > arr1[j])
                    {
                          tmp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j+1] = tmp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Nhong’s Sort ... ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");



            ///////////////////// แบบที่ 4
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number - 1; j++)
                {
                    if (arr1[j] > arr1[j+1]) /////------> ต่างกับแบบที่ 3 ตรงนี้
                    {
                        tmp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j] = tmp; /////------> ต่างกับแบบที่ 3 ตรงนี้
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Toddy’s Sort ... ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");




        }
    }
   





}

   
  