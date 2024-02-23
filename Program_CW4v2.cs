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
    public class Program_CW4_v2
    {
        public static void Main_CW4_v2(string[] args)
        {
            /*
            Question Name : Create Phone Number
            Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
            */
            
           /* stringarray[i] = intarray[i].ToString(); --------->>> integer'i string'e çevirme*/
            
            int [] nums = new int [10];
            string [] phone = new string[14];
            
            Console.WriteLine("Input the numbers of your phone one by one (10 numbers must): ");

            int a = 3;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Number "+(i+1)+" : ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            phone[0] = "(";
            phone[4] = ")";
            phone[5] = " ";
            phone[9] = "-";

            for(int i = 0; i < a; i++)
            {
                phone[i+1] = nums[i].ToString();
            }
            for(int i = 0; i < a; i++)
            {
                phone[i+(a*2)] = nums[i+a].ToString();
            }
            for(int i = 0; i < a+1; i++)
            {
                phone[i+(a*3)+1] = nums[i+(a*2)].ToString();
            }
            for(int i = 0; i < 14; i++)
            {
                Console.Write(phone[i]);
            }
             
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}