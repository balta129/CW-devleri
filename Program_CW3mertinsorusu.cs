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
    public class Program_CW3
    {
        public static void Main_CW3(string[] args)
        {
            
            Console.Write("Input the number of elements to be stored in the array : ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int [] nums = new int [numbers];
            
            Console.WriteLine("Input numbers: ");


            for(int i = 0; i < numbers; i++)
            {
                Console.Write("Number "+(i+1)+" : ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter k : ");
            int k = Convert.ToInt32(Console.ReadLine());
            int [] nums2 = new int [numbers-k+1];
            int [] transfer = new int [numbers];
            
                 for (int i = 0; i < nums.Length-k+1; i++)
                {
                    int max = nums[i];
                    for (int j = 1; j < k; j++)
                    {
                      if(nums[j+i] > max)
                      {
                        max = nums[j+i];
                      }     
                    }
                    nums2[i] = max;    
                }
                Console.WriteLine("biggest numbers : ");
                for(int i = 0 ; i < nums2.Length; i++)
                {
                    Console.Write(nums2[i] +" ");
                }




            
            
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}