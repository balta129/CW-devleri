using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_CW2
    {
        public static void Main_CW2(string[] args)
        {
            
        /*
        Question Name : Product Of Maximums Of Array (Array Series #2)
        Task
        Given an array/list [] of integers , Find the product of the k maximal numbers.

        maxProduct ({4, 3, 5}, 2) ==>  return (20)
        Explanation:
        Since the size (k) equal 2 , then the subsequence of size 2 whose gives product of maxima is 5 * 4 = 20 .
----------------------------------------------------------------------------------------------------------
        maxProduct ({8, 10 , 9, 7}, 3) ==>  return (720)
        Explanation:
        Since the size (k) equal 3 , then the subsequence of size 3 whose gives product of maxima is  8 * 9 * 10 = 720 .
        */

            Console.Write("Input the number of the elements in the array : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] array = new int [number];
           

            Console.WriteLine("Input " + number + " elements in the array :");
                for(int i = 0; i < number; i++)
            {      
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter the 'k' value : ");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        a = array[j+1];
                        array[j+1] = array[j];
                        array[j] = a;
                    }
                }
            }
            Console.Write("Result : ");
            int max = 1;
            for(int i = 0; i < k; i++)
            {
                max = max*array[number-1-i];
            }
            Console.Write(max);
                
               


            
            
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}
