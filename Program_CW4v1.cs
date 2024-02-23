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
    public class Program_CW4_v1
    {
        public static void Main_CW4_v1(string[] args)
        {
            /*
            Question Name : Create Phone Number
            Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
            */
            
           
            int [] nums = new int [10];
            
            Console.WriteLine("Input the numbers of your phone one by one (10 numbers must): ");

            int a = 3;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Number "+(i+1)+" : ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("(");
            for(int i = 0; i < a; i++)
            {
                Console.Write(nums[i]);
            }
            Console.Write(")");
            Console.Write(" ");
            for(int i = 0; i < a; i++)
            {
                Console.Write(nums[i+a]);
            }
           Console.Write("-");
           for(int i = 0; i < a+1; i++)
           {
            Console.Write(nums[i+(2*a)]);
           }

            
            
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}