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
    public class Program_CW7
    {
        public static void Main_CW7(string[] args)
        {
            /* https://www.codewars.com/kata/52597aa56021e91c93000cb0
            Moving Zeros To The End
            */
          int [] numbers = {1,2,1,0,0,0,1,0,3,0,0,0,1};
        
          for(int i = 0; i < numbers.Length; i++)
          { 
            int a = 0;
              for(int j = i+1; j < numbers.Length-1; j++)
              {
                
                if(numbers[i] == 0)
                {
                    if(numbers[j] == 0)
                    {
                    a = numbers[j];
                    numbers[j] = a;  
                    }
                    else
                    {  
                    a = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = a;     
                    }
                }
                else
                {
                    break;
                }              
              }
          }
          int b = 0;
          for(int i = numbers.Length-1; i > 0; i--)
          {
            if(numbers[i] != 0)
            {   
                if(numbers[i-1] == 0)
                {
                b = numbers[i-1];
                numbers[i-1] = numbers[i];
                numbers[i] = b;
                }
                else
                {
                    break;
                }
            }
          }
          Console.WriteLine(" ");
          Console.Write("Output: ");
          for (int i = 0; i < numbers.Length; i++)
          {
            Console.Write(numbers[i]+" ");
          }

        }
          
    }
}
